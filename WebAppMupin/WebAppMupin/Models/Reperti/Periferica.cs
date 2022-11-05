using MapDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMupin.Models.Reperti
{
    [GenerateDataReaderMapper]
    public class Periferica
    {
        public string Identificativo { get; set; }
        public string nomeModello { get; set; }
        public string Tipologia { get; set; }

    }
}