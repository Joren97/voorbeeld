using publishers_models;
using System;
using System.Collections.Generic;

namespace publishers_dal
{
    public interface IEmployeesRepository
    {
        public IEnumerable<Employee> OphalenEmployeesPublishersJobs(string publisher = "");

        public Employee OphalenEmployeeViaPK(string emp_id);

        public IEnumerable<Employee> OphalenEmployees();

        public List<Employee> OphalenEmployeesViaJob_id(int job_id);

        public List<Employee> OphalenEmployeesViaPub_id(string pub_id);

        public List<Employee> OphalenEmployeesViaPub_idEnJob_id(string pub_id, int job_id);

        public List<Employee> OphalenEmployeesViaHireDate(DateTime hiredate);
    }
}