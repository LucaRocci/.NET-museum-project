using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMupin.Models.Reperti
{
    public class Libro
    {
        public string Identificativo { get; set; }
        public string Titolo { get; set; }
        public string autori { get; set; }


        public string Note { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }
    }
}