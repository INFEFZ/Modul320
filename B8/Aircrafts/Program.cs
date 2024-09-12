using System;

namespace E02.Vererbung.Aircrafts.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hangar h = new Hangar("Hangar A51", "Basel");

            Flugzeug f = new Flugzeug("Airbus", 2012, 80.0)
            {
                Power = new Motor("Düsenjet", "Airbus")
            };

            // Zum Hangar hinzufügen
            h.Luftfahrzeuge.Add(f);

            f = new Flugzeug("Airbus", 2012, 60.0)
            {
                Power = new Motor("Düsenjet", "Airbus")
            };

            h.Luftfahrzeuge.Add(f);

            Hubschrauber hubi = new Hubschrauber("Super Puma", 2002, 20.0)
            {
                Power = new Motor("Puma", "Puma")
            };


            h.Luftfahrzeuge.Add(hubi);

            Zeppelin z = new Zeppelin("Hindenburg", 1937, 200000.0)
            {
                Power = new Motor("Zeppi", "Zeppi ZZ++")
            };

            h.Luftfahrzeuge.Add(z);

            Console.WriteLine($"Anzahl Luftfahrzeuge im Hangar: {h.Luftfahrzeuge.Count}");

            int[] counter = new int[3] { 0, 0, 0 };

            foreach (var item in h.Luftfahrzeuge)
            {
                if(item is Flugzeug)
                {
                    counter[0]++;
                }
                else if(item is Zeppelin)
                {
                    counter[1]++;
                }
                else if(item is Hubschrauber)
                {
                    counter[2]++;
                }
            }
            Console.WriteLine($"Flugzeug:{counter[0]}, Zeppelin:{counter[1]}, Hubschrauber:{counter[2]}");


            // Erstes Element in Liste
            Luftfahrzeug luftf = h.Luftfahrzeuge[0];

            Flugzeug ff = luftf as Flugzeug;
            if(ff != null)
            {
                Console.WriteLine(ff.ToString());
            }

            // Liste anzeige
            foreach (var lfz in h.Luftfahrzeuge)
            {
                if (lfz is Flugzeug)
                {
                    Flugzeug t = lfz as Flugzeug;
                    Console.WriteLine(t.ToString());
                }
                else if (lfz is Hubschrauber)
                {
                    Hubschrauber t = lfz as Hubschrauber;
                    Console.WriteLine(t.ToString());
                }
                else if (lfz is Zeppelin)
                {
                    Zeppelin t = lfz as Zeppelin;
                    Console.WriteLine(t.ToString());
                }
                else
                {
                    Console.WriteLine($"{lfz.Hersteller}\t{lfz.Baujahr}\t{lfz.Power.Name}");
                }
            }

            // Jetzt starten alle LFZ
            foreach (Luftfahrzeug lfz in h.Luftfahrzeuge)
            {
                lfz.Starten();
            }

            // Jetzt laden alle LFZ
            foreach (var lfz in h.Luftfahrzeuge)
            {
                lfz.Landen();
            }

            //Flugzeug fz = new Luftfahrzeug();

            //Flugzeug fz = new Flugzeug();
            Luftfahrzeug fz = new Flugzeug();
            //fz.Starten();


            Console.ReadKey();
        }
    }
}
