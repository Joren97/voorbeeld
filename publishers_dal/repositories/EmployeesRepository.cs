using Dapper;
using publishers_models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace publishers_dal
{
    public class EmployeesRepository : BaseRepository, IEmployeesRepository
    {
        public IEnumerable<Employee> OphalenEmployeesPublishersJobs(string publisher = "")
        {
            var sql = @"SELECT E.*, '' AS SplitCol, P.*, '' AS SplitCol, J.*
                        FROM Employees E
                        JOIN Publishers P ON E.pub_id = P.pub_id
                        JOIN Jobs J ON E.job_id = J.job_id
                        WHERE P.pub_name LIKE '%' + @publisher + '%'
                        ORDER BY E.fname, E.lname";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee, Publisher, Job, Employee>(
                    sql,
                    (employee, publisher, job) =>
                    {
                        employee.Job = job;
                        employee.Publisher = publisher;
                        return employee;
                    },
                    new { publisher = publisher },
                    splitOn: "SplitCol"
                );
            }
        }

        public IEnumerable<Employee> OphalenEmployees()
        {
            string sql = "SELECT * FROM Employees ORDER BY lname, fname";
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>(sql);
            }
        }

        public List<Employee> OphalenEmployeesViaHireDate(DateTime hiredate)
        {
            string sql = "SELECT * FROM Employees WHERE hire_date <= @hiredate ORDER BY lname, fname";
            var parameters = new { @hiredate = hiredate };
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>(sql, parameters).AsList();
            }
        }

        public List<Employee> OphalenEmployeesViaJob_id(int job_id)
        {
            string sql = "SELECT * FROM Employees WHERE job_id = @job_id ORDER BY lname, fname";
            var parameters = new { @job_id = job_id };
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>(sql, parameters).AsList();
            }
        }

        public List<Employee> OphalenEmployeesViaPub_id(string pub_id)
        {
            string sql = "SELECT * FROM Employees WHERE pub_id = @pub_id ORDER BY lname, fname";
            var parameters = new { @pub_id = pub_id };
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>(sql, parameters).AsList();
            }
        }

        public List<Employee> OphalenEmployeesViaPub_idEnJob_id(string pub_id, int job_id)
        {
            string sql = "SELECT * FROM Employees " +
                "WHERE pub_id = @pub_id " +
                "AND (@job_id = job_id OR @job_id=0) " +
                "ORDER BY lname, fname";
            var parameters = new { @pub_id = pub_id, @job_id = job_id };
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>(sql, parameters).AsList();
            }
        }

        public Employee OphalenEmployeeViaPK(string emp_id)
        {
            string sql = "SELECT * FROM Employees WHERE emp_id = @emp_id ";
            var parameters = new { @emp_id = emp_id };
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.QuerySingleOrDefault<Employee>(sql, parameters);
            }
        }
    }
}