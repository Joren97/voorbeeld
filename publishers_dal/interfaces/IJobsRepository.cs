using System;
using System.Collections.Generic;
using System.Text;
using publishers_models;

namespace publishers_dal
{
    public interface IJobsRepository
    {
        public IEnumerable<Job> OphalenJobs();
    }
}
