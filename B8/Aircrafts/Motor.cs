namespace E02.Vererbung.Aircrafts.ConsoleApp
{
    public class Motor
    {
        public string Hersteller { get; set; }
        public float Leistung { get; set; }
        public string Name { get; set; }
        public int Gewicht { get; set; }

        public Motor()
        {
            Hersteller = string.Empty;
            Leistung = 0.0f;
            Name = string.Empty;
            Gewicht = 0;
        }

        public Motor(string name, string hersteller)
            : this()
        {
            Name = name;
            Hersteller = hersteller;
        }

        public override string ToString()
        {
            return $"Name={Name},Hersteller={Hersteller},Leistung={Leistung},Gewicht={Gewicht}"; 
        }
    }
}
