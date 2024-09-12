using System;

namespace GeometricFigures
{
    public class GeomFigur
    {
        protected double[] _seiten = new double[0];

        protected GeomFigur(double[] s)
        {
            Console.WriteLine("--> GeomFigur Konstruktor");
            _seiten = s;
        }

        public override string ToString()
        {
            string result = "Seitenlängen: ";
            foreach (var d in _seiten)
            {
                result += $"{d} ";
            }

            return result;
        }
    }
}
