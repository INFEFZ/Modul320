using System;

namespace CircleLibrary
{
    /// <summary>
    /// Kreisklasse
    /// </summary>
    /// <remarks>
    /// Übung Kreisklasse aus dem Buch
    /// </remarks>
    public class Circle
    {
        /// <summary>
        /// X Koordinate, Kreismittelpunkt
        /// </summary>
        public double XCoordinate { get; set; }

        /// <summary>
        /// Y Koordinate, Kreismittelpunkt
        /// </summary>
        public double YCoordinate { get; set; }

        /// <summary>
        /// Radius des Kreises
        /// </summary>
        private int _Radius;

        /// <summary>
        /// Radius des Kreises
        /// </summary>
        /// <remarks>
        /// Radius muss > 0 sein
        /// </remarks>
        public int Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                {
                    _Radius = value;
                }
                else
                {
                    Console.WriteLine("Unzulässiger negativer Radius.");
                }
            }
        }

        /// <summary>
        /// Klasseneigenschaft Anzahl Kreise
        /// </summary>
        private static int _CountCircles = 0;

        /// <summary>
        /// Anzahl der Kreisobjekte
        /// </summary>
        public static int CountCircles
        {
            get { return _CountCircles; }
        }

        /// <summary>
        /// Standard Konstruktur
        /// </summary>
        public Circle()
        {
            Radius = 0;
            XCoordinate = 0;
            YCoordinate = 0;
            Circle._CountCircles++;
        }

        /// <summary>
        /// Kontruktor
        /// </summary>
        /// <param name="radius">Radius des Kreises</param>
        public Circle(int radius)
            :this()
        {
            Radius = radius;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="radius">Radius des Kreises</param>
        /// <param name="x">X Koordinate des Kreismittelpunktes</param>
        /// <param name="y">Y Koordinate des Kreismittelpunktes</param>
        /// <example>Circle c = new Circle(10, 100, 200)</example>
        public Circle(int radius, double x, double y)
            :this(radius)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        /// <summary>
        /// Destruktor
        /// </summary>
        ~Circle()
        {
            Circle._CountCircles--;
            Console.WriteLine("Destruktor ausgeführt");
        }

        /// <summary>
        /// Fläche berechnen
        /// </summary>
        /// <returns>Fläche des Kreises</returns>
        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        /// <summary>
        /// Umfang berechnen
        /// </summary>
        /// <returns>Umfang des Kreises</returns>
        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        /// <summary>
        /// Grössenvergleich der Kreise
        /// </summary>
        /// <param name="kreis">Kreis</param>
        /// <returns>0=identisch, 1=grösser, -1=kleiner</returns>
        public int Bigger(Circle kreis)
        {
            if (Radius > kreis.Radius) return 1;
            if (Radius < kreis.Radius) return -1;
            else return 0;
        }

        /// <summary>
        /// Positionierung
        /// </summary>
        /// <param name="dx">Verschiebung in XKoordinate</param>
        /// <param name="dy">Verschiebung in YKoordinate</param>
        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        /// <summary>
        /// Positionierung
        /// </summary>
        /// <param name="dx">Verschiebung in XKoordinate</param>
        /// <param name="dy">Verschiebung in YKoordinate</param>
        /// <param name="dRadius">Grössenänderung des Radius</param>
        public void Move(double dx, double dy, int dRadius)
        {
            Move(dx, dy);
            Radius += dRadius;
        }

        /// <summary>
        /// Versionstring
        /// </summary>
        /// <returns>Version der Klasse</returns>
        public string Version()
        {
            return "IBZ Super++ V1.0";
        }



        /// <summary>
        /// Compare Cycle
        /// </summary>
        /// <param name="kreis1"></param>
        /// <param name="kreis2"></param>
        /// <returns></returns>
        public static int Bigger(Circle kreis1, Circle kreis2)
        {
            if (kreis1 == null && kreis2 == null) return 0;
            if (kreis1 == null) return -1;
            if (kreis2 == null) return 1;
            if (kreis1.Radius > kreis2.Radius) return 1;
            if (kreis1.Radius < kreis2.Radius) return -1;
            return 0;
        }

        /// <summary>
        /// Calc Circumference
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double GetCircumference(int radius)
        {
            return 2 * radius * Math.PI;
        }

        /// <summary>
        /// Calculate Area
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double GetArea(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
