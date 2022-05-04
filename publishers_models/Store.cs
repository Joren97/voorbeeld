using System;
using System.Collections.Generic;
using System.Text;

namespace publishers_models
{
    public class Store
    {
        public string stor_id { get; set; }
        public string stor_name { get; set; }
        public string stor_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

        public override string ToString()
        {
            return $"{stor_name} ({zip} {city})";
        }
    }
}
