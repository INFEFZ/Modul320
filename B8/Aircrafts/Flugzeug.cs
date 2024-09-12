using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace E02.Vererbung.Aircrafts.ConsoleApp
{
    public class Flugzeug : Luftfahrzeug
    {
        public double Spannweite { get; set; }

        public Flugzeug()
            :this(string.Empty, 0, 0.0)
        {
        }

        public Flugzeug(string hersteller, int baujahr, double spannweite)
            :base(hersteller, baujahr)
        {
            Spannweite = spannweite;
        }

        public override void Starten()
        {
            Console.WriteLine("Das Flugzeug startet.");
        }

        public override void Landen()
        {
            Console.WriteLine("Das Flugzeug landet.");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t{Spannweite}";
        }

        public override void Tanken()
        {
            Console.WriteLine("Das Flugzeug wird getankt");
        }
    }
}
