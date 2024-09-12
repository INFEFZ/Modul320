using System;

namespace GeometricFigures
{
    public class Dreieck : GeomFigur
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="s">Seitenlängen des Dreiecks</param>
        public Dreieck(double[] s)
            :base(s)
        {
            if (s.Length != 3)
                throw new ArgumentException("Falsche Anzahl der Seitenlängen");

            Console.WriteLine("--> Dreieck Konstruktor");
        }

        /// <summary>
        /// Umfang berechnen
        /// </summary>
        /// <returns>Umfang des Dreiecks</returns>
        public double Umfang()
        {
            return _seiten[0] + _seiten[1] + _seiten[2];
        }

        /// <summary>
        /// Information zu den Seitenlägen des Dreiecks
        /// </summary>
        /// <returns>Dump String</returns>
        public override string ToString()
        {
            return "Dreieck =>" + base.ToString();
        }
    }
}
