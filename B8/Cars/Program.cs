using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCars2
{
    class Program
    {
        static void Main(string[] args)
        {
            PKW pw = new PKW(2016, "Blau", 5);

            // So nicht !!!!
            // Console.WriteLine($"Baujahr={pw.Baujahr}, Farbe={pw.Farbe}, Sitzplätze={pw.Sitzplaetze}");

            // Besser delegieren in Klasse (Delegation), will kein Hobby Programmierer sein, Note = 6!
            Console.WriteLine(pw.ToString());

            Console.ReadKey();
        }
    }
}
