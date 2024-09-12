namespace TierApp
{
	public class Katze : ITier
	{
		public string Geschlecht { get; set; } = string.Empty;
		public int Alter { get; set; }

		public Katze()
		{

		}

		public Katze(string geschlecht, int alter)
		{
			Geschlecht = geschlecht;
			Alter = alter;
		}

		public void Fressen()
		{
			Console.WriteLine("Die Katze frisst!");
		}

		public void Trinken()
		{
			Console.WriteLine("Die Katze trinkt!");
		}
	}
}
