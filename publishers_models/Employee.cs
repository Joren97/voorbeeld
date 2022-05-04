using System;
using System.Collections.Generic;
using System.Text;

namespace publishers_models
{
    public class Employee
    {
        public string emp_id { get; set; }
        public string fname { get; set; }
        public string minit { get; set; }
        public string lname { get; set; }
        public short job_id { get; set; }
        public Nullable<byte> job_lvl { get; set; }
        public string pub_id { get; set; }
        public System.DateTime hire_date { get; set; }

        public Job Job { get; set; } 
        public Publisher Publisher { get; set; }

        public override string ToString()
        {
            return $"{fname} {lname} werkt bij {Publisher?.pub_name} als {Job}";
        }
    }
}
