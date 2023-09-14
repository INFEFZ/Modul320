using CircleLibrary;
using System;


namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanziieren 
            Circle c1 = new Circle(10, 100, 200);

            double umfang = c1.GetCircumference();
            double flaeche = c1.GetArea();
            Console.WriteLine($"Radius = {c1.Radius}, Umfang = {umfang}, Fläche = {flaeche}");

            Console.ReadKey();










            //Circle c = new Circle(10, 100, 200);
            //Circle c2 = new Circle(20, 100, 200);

            //Console.WriteLine($"Grösser oder kleiner = {c.Bigger(c2)}");

            //c.Radius = 10;
            //double f = c.GetArea();
            //double u = c.GetCircumference();

            //variante 1
            //Console.WriteLine($"Radius = {c.Radius}, Fläche = {f}, Umfang = {u}");

            //variante 2
            //Console.WriteLine("Radius = {0}, Fläche = {1}, Umfang = {2}",
            //                    c.Radius, f, u);


            //c.Move(100, 100, 20);
            //Console.WriteLine($"Radius = {c.Radius}, XKoordinate = {c.XCoordinate}, YKoordinate = {c.YCoordinate}");
            //Console.ReadKey();








            //Console.WriteLine($"Version={c.Version()}");

        }
    }
}
