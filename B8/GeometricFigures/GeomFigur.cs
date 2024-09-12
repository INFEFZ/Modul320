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

        public virtual string Information()
        {
            string result = "Seitenlängen: ";
            foreach (double d in _seiten)
            {
                result += $"{d} ";                
            }

            return result;
        }

        public override string ToString()
        {
            string result = "Seitenlängen: ";
            foreach (double d in _seiten)
            {
                result += $"{d} ";
            }

            return result;
        }


    }
}
