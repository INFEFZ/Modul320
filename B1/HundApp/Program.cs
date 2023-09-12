namespace HundApp
{
    /// <summary>
    /// Übungsbeispiel Klassenmodul erstellen
    /// Modul 320
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Hier beginnt das Programm (Einstiegspunkg)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Bello
            Hund bello = new Hund("Bello", 4, "Boxer", "M");
            bello.Bellen();
            bello.Fressen();

            // Rocky
            Hund rocky = new Hund("Rocky", 2, "Labrador Retriever", "M");
            rocky.Bellen();
            rocky.Fressen();

            Console.WriteLine("Programm beenden mit <ENTER>");
        }
    }
}
