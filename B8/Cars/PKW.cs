using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCars2
{
    public class PKW : Auto
    {
        public int Sitzplaetze { get; set; }

        public PKW()
            :base()
        {

        }

        public PKW(int baujahr, string farbe, int sitzplaetze)
            :base(baujahr, farbe)
        {
            Sitzplaetze = sitzplaetze;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Sitzplätze={Sitzplaetze}";  
        }
    }
}
