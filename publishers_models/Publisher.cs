using System;
using System.Collections.Generic;
using System.Text;

namespace publishers_models
{
    public class Publisher
    {
        public string pub_id { get; set; }
        public string pub_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
		public string pub_id { get; set; }
        public string pub_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
		public string pub_id { get; set; }
        public string pub_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public override string ToString()
        {
            return $"{pub_name} ({city}, {country})";
        }
    }
}
