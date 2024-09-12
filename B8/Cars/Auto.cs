using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCars2
{
    public abstract class Auto
    {
        public int Baujahr { get; set; }
        public string Farbe { get; set; }

        public Auto()
        {

        }

        public Auto(int baujahr, string farbe)
        {
            Baujahr = baujahr;
            Farbe = farbe;
        }

        public override string ToString()
        {
            return $"Baujahr={Baujahr}, Farbe={Farbe}";
        }
    }
}
