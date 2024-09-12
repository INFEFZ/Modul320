namespace PersonApp
{
	public class Teacher : Person
	{
		public Teacher(string firstName, string lastName, int age) 
			: base(firstName, lastName, age)
		{
		}

		public string Teach()
		{
			return $"Herr/Frau {LastName} unterrichtet die Klasse!";
		}
	}
}
