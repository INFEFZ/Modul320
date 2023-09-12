namespace HundApp
{
    /// <summary>
    /// Aufgabe Modul 320
    /// Klasse Hund implementieren
    /// </summary>
    public class Hund
    {
        /// <summary>
        /// Hunde name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Alter des Hundes in Jahren
        /// </summary>
        public int Age { get; set; } = 0;

        /// <summary>
        /// Hundrasse (Terrier, Boxer, Pudel, Dackel)
        /// </summary>
        public string Rasse { get; set; } = string.Empty;

        /// <summary>
        /// Geschlecht des Hudes (M/W)
        /// </summary>
        public string Geschlecht { get; set; } = "M";

        /// <summary>
        /// Konstruktur
        /// </summary>
        public Hund() { }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Name des Hundes</param>
        /// <param name="age">Alter in Jahren</param>
        /// <param name="rasse">Hunderasse</param>
        /// <param name="geschlecht">Geschlecht M/W</param>
        public Hund(string name, int age, string rasse, string geschlecht)
        {
            Name=name;
            Age=age;
            Rasse=rasse;
            Geschlecht=geschlecht;
        }

        /// <summary>
        /// Hund soll bellen
        /// </summary>
        public void Bellen()
        {
            Console.WriteLine($"{Name} bellt!");
        }

        /// <summary>
        /// Hund soll fressen
        /// </summary>
        public void Fressen()
        {
            Console.WriteLine($"{Name} fristt!");
        }

    }
}
