using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KørselsBog
{
    public class Kunde
    {
        public int KundeID { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        //public string BilID { get; set; }
        public DateTime Oprettelsesdato { get; set; }
    }
}
