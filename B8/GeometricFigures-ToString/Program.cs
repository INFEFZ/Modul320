using System;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
				Rechteck r = new Rechteck(new double[] { 10.0, 20.0 });
				Console.WriteLine($"Rechteckfläche={r.RechteckFlaeche()}");
				Console.WriteLine(r);

				Dreieck d = new Dreieck(new double[] { 10.0, 20.0, 30.0 });
				Console.WriteLine($"Dreieckumfang={d.Umfang()}");
				Console.WriteLine(d);

				Quadrat q = new Quadrat(new double[] { 10.0 });
				Console.WriteLine($"Quadratfläche={q.QuadratFlaeche()}");
				Console.WriteLine(q);
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
