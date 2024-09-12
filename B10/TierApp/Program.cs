using TierApp;

internal class Program
{
	private static void Main(string[] args)
	{
        ITier[] tierArray = new ITier[]
		{
			new Hund() { Geschlecht = "Männlich", Alter = 10},          
			new Katze() { Geschlecht = "Weibich", Alter = 4},
			new Maus() { Geschlecht = "Männlich", Alter = 1}
		};

		foreach (var tier in tierArray)
		{
			Console.WriteLine($"Geschlecht:{tier.Geschlecht}\nAlter: {tier.Alter}");
			tier.Fressen();
			tier.Trinken();
		}
	}
}