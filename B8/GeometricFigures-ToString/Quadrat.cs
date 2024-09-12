using System;

namespace GeometricFigures
{
    public class Quadrat : Rechteck
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="s"></param>
        public Quadrat(double[] s)
            :base(s)
        {
            Console.WriteLine("--> Quadrat Konstruktor");
        }

        /// <summary>
        /// Fläche berechnen
        /// </summary>
        /// <returns>Fläche des Quadrates</returns>
        public double QuadratFlaeche()
        {
            return _seiten[0] * _seiten[0];
        }

        public override string ToString()
        {
            return "Quadrat =>" + base.ToString();
        }
    }
}
