using System;
using System.Collections.Generic;
using System.Text;

namespace publishers_models
{
    public class Title
    {
        public string title_id { get; set; }
        public string title_name { get; set; }
        public string type { get; set; }
        public string pub_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> advance { get; set; }
        public Nullable<int> royalty { get; set; }
        public Nullable<int> ytd_sales { get; set; }
        public string notes { get; set; }
        public System.DateTime pubdate { get; set; }

        public Publisher Publisher { get; set; }

        public override string ToString()
        {
            var indent = new String(' ', 5);
            var str = $"{title_name}{Environment.NewLine}";
            str += $"{indent}Uitgever: {Publisher}{Environment.NewLine}";
            str += $"{indent}Uitgave datum: {pubdate}{Environment.NewLine}";
            return str;
        }
    }
}
