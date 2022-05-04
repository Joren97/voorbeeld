using System;
using System.Collections.Generic;
using System.Text;

namespace publishers_models
{
    public class Job
    {
        public short job_id { get; set; }
        public string job_desc { get; set; }
        public byte min_lvl { get; set; }
        public byte max_lvl { get; set; }

        public override string ToString()
        {
            return job_desc;
        }
    }
}
