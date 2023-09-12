namespace ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            // Variante 1
            names.Add("Peter");
            names.Add("Alina");
            names.Add("Sabine");
            names.Add("Florian");

            // Variante 2
            // names.AddRange(new string[] { "Peter", "Alina", "Sabine", "Florian"});

            // alle Namen ausgeben
            Console.WriteLine("Unsortiert");
            Console.WriteLine("------------------------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // erstes Element
            string nFirst = names[0];

            // letztes Element
            string nLast = names[names.Count - 1];

            names.Sort();
            Console.WriteLine("\n");
            Console.WriteLine("Sortiert");
            Console.WriteLine("------------------------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Weiter mit <Enter>");
        }
    }
}