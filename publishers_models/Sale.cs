using System;

namespace publishers_models
{
    public class Sale
    {
        public string stor_id { get; set; }
        public string ord_num { get; set; }
        public System.DateTime ord_date { get; set; }
        public short qty { get; set; }
        public string payterms { get; set; }
        public string title_id { get; set; }

        public Store Store { get; set; }
        public Title Title { get; set; }

        public override string ToString()
        {
            var indent = new String(' ', 5);
            var str =  $"Verkoop in {Store} op {ord_date}{Environment.NewLine}";
            str += $"{indent}{qty} x {Title?.title_name}";
            return str;
        }
    }
}
