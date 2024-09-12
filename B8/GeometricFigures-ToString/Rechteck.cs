using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Rechteck : GeomFigur
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="s"></param>
        public Rechteck(double[] s)
            :base(s)
        {
            if (s.Length != 2)
                throw new ArgumentException("Falsche Seitenanzahl");

            Console.WriteLine("--> Rechteck Konstruktor");
        }

        /// <summary>
        /// Fläche berechnen
        /// </summary>
        /// <returns>Fläche des Rechtecks</returns>
        public double RechteckFlaeche()
        {
            return _seiten[0] * _seiten[1];
        }

        /// <summary>
        /// Information des Rechtecks
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rechteck =>" + base.ToString();
        }
    }
}
