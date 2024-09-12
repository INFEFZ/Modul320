using System;

namespace E02.Vererbung.Aircrafts.ConsoleApp
{
    public class Zeppelin : Luftfahrzeug
    {
        public double Gasvolumen { get; set; }

        public Zeppelin()
            :this(string.Empty, 0, 0.0)
        {

        }

        public Zeppelin(string hersteller, int baujahr, double gasvolumen)
            :base(hersteller, baujahr)
        {
            Gasvolumen = gasvolumen;
        }

        public override void Starten()
        {
            Console.WriteLine("Der Zeppelin startet.");
        }

        public override void Landen()
        {
            Console.WriteLine("Der Zeppelin landet.");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t{Gasvolumen}";
        }

        public override void Tanken()
        {
            Console.WriteLine("Der Zeppelin wird getankt");
        }
    }
}
