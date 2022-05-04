using Dapper;
using publishers_models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace publishers_dal
{
    public class JobsRepository : BaseRepository, IJobsRepository
    {
        public IEnumerable<Job> OphalenJobs()
        {
            string sql = "SELECT * FROM jobs ORDER BY job_desc";
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Job>(sql);
            }
        }
    }
}