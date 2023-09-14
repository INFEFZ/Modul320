using System;

namespace GeometricObjects
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
        /// PI
        /// </summary>
        public const double PI = 3.14;

        /// <summary>
        /// X Koordinate
        /// </summary>
        public double XCoordinate { get; set; }

        /// <summary>
        /// Y Koordinate
        /// </summary>
        public double YCoordinate { get; set; }

        /// <summary>
        /// Radius
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
                    _Radius = value;
                else
                    Console.WriteLine("Unzulässiger negativer Radius.");
            }
        }

        // ---------- Klasseneigenschaft -----------------
        private static int _CountCircles = 0;

        /// <summary>
        /// Get number of Cycle objects
        /// </summary>
        public static int CountCircles
        {
            get { return _CountCircles; }
        }

        /// <summary>
        /// Konstruktur
        /// </summary>
        public Circle()
            : this(0, 0, 0)
        {
        }

        /// <summary>
        /// Kontruktor
        /// </summary>
        /// <param name="radius"></param>
        public Circle(int radius)
            : this(radius, 0, 0)
        {

        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="radius">Radius des Kreises</param>
        /// <param name="x">X Koordinate des Kreismittelpunkts</param>
        /// <param name="y">Y Koordinate des Kreismittelpunkts</param>
        /// <example>Circle c = new Circle(10, 100, 200)</example>
        public Circle(int radius, double x, double y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            Circle._CountCircles++;
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
        /// Flaeche berechnen
        /// </summary>
        /// <returns>Fläche</returns>
        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        /// <summary>
        /// Umfang berechnen
        /// </summary>
        /// <returns>Umfang</returns>
        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        /// <summary>
        /// Grössenvergleich
        /// </summary>
        /// <param name="kreis"></param>
        /// <returns></returns>
        public int Bigger(Circle kreis)
        {
            if (kreis == null || Radius > kreis.Radius) return 1;
            if (Radius < kreis.Radius) return -1;
            else return 0;
        }

        /// <summary>
        /// Positionierung
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        /// <summary>
        /// Positionierung
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dRadius"></param>
        public void Move(double dx, double dy, int dRadius)
        {
            this.Move(dx, dy);
            Radius += dRadius;
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
    }
}
