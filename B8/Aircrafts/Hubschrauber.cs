using System;

namespace E02.Vererbung.Aircrafts.ConsoleApp
{
    public class Hubschrauber : Luftfahrzeug
    {
        public double RotorDurchmesser { get; set; }

        public Hubschrauber()
            :this(string.Empty, 0, 0.0)
        {
        }

        public Hubschrauber(string hersteller, int baujahr, double rotordurchmesser)
            :base(hersteller, baujahr)
        {
            RotorDurchmesser = rotordurchmesser;
        }


        public override void Starten()
        {
            Console.WriteLine("Der Hubschrauber startet.");
        }

        public override void Landen()
        {
            Console.WriteLine("Der Hubschrauber landet.");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t{RotorDurchmesser}";
        }

        public override void Tanken()
        {
            Console.WriteLine("Der Hubschrauber wird getankt");
        }
    }
}
