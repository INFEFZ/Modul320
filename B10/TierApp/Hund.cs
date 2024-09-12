namespace TierApp
{
	public class Hund : ITier
	{
		public string Geschlecht { get; set; } = string.Empty;
		public int Alter { get; set; }

		public Hund()
		{

		}

		public Hund(string geschlecht, int alter)
		{
			Geschlecht = geschlecht;
			Alter = alter;
		}

		public void Fressen()
		{
			Console.WriteLine("Der Hund frisst!");
		}

		public void Trinken()
		{
			Console.WriteLine("Der Hund trinkt!");
		}
	}
}
