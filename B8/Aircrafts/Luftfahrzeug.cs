using System;

namespace E02.Vererbung.Aircrafts.ConsoleApp
{
    public abstract class Luftfahrzeug
    {
        public string Hersteller { get; set; } = string.Empty;
        public int Baujahr { get; set; } = 0;
        public Motor Power { get; set; } = new Motor();

        public Luftfahrzeug()
            : this(string.Empty, 0)
        {
        }

        public Luftfahrzeug(string hersteller, int baujahr)
        {
            Power = new Motor();

            Hersteller = hersteller;
            Baujahr = baujahr;
        }

        public abstract void Tanken();

        public virtual void Starten()
        {
            Console.WriteLine("Das Luftfahrzeug startet.");
        }

        public virtual void Landen()
        {
            Console.WriteLine("Das Luftfahrzeug landet.");
        }

        public override string ToString()
        {
            return $"{Hersteller}\t{Baujahr}\t{Power}";
        }
    }
}
