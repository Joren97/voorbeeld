using System;
using System.Collections.Generic;
using System.Text;

namespace publishers_models
{
    public class TitleAuthor
    {
        public string au_id { get; set; }
        public string title_id { get; set; }
        public Nullable<byte> au_ord { get; set; }
        public Nullable<int> royaltyper { get; set; }
    }
}
