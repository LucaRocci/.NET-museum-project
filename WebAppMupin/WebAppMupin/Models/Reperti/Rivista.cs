using MapDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMupin.Models.Reperti
{
    [GenerateDataReaderMapper]
    public class Rivista
    {
        public string Identificativo { get; set; }
        public string Titolo { get; set; }
        public string numeroRivista { get; set; }
        public string Anno { get; set; }
        public string casaEditrice { get; set; }    

    }
}