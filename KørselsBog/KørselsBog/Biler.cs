using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KørselsBog
{
    class Biler
    {
        public int BilID { get; set; }
        public string RegNr { get; set; }
        public string Mærke { get; set; }
        public string Model { get; set; }
        public string Brændstoftype { get; set; }
        public string Oprettelsesdato { get; set; }
        public int Kmkørt { get; set; }
        public int Årgang { get; set; }
    }
}
