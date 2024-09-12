namespace TierApp
{
	public class Maus : ITier
	{
		public string Geschlecht { get; set; } = string.Empty;
		public int Alter { get; set; }

		public Maus()
		{

		}
		public Maus(string geschlecht, int alter)
		{
			Geschlecht = geschlecht;
			Alter = alter;
		}

		public void Fressen()
		{
			Console.WriteLine("Die Maus frisst!");
		}

		public void Trinken()
		{
			Console.WriteLine("Die Maus trinkt!");
		}
	}
}
