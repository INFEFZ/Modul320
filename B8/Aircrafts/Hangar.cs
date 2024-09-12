using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02.Vererbung.Aircrafts.ConsoleApp
{
    public class Hangar
    {
        public List<Luftfahrzeug> Luftfahrzeuge { get; set; }
        public string Name { get; set; }
        public string Ort { get; set; }

        public Hangar()
            : this(string.Empty, string.Empty)
        {
        }

        public Hangar(string name, string ort)
        {
            Name = name;
            Ort = ort;
            Luftfahrzeuge = new List<Luftfahrzeug>();
        }
    }
}
