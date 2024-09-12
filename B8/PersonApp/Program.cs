using PersonApp;

internal class Program
{
	private static void Main(string[] args)
	{
		List<Person> peopleInClassroom = new List<Person>()
		{
			new Teacher("John", "Smith", 32),
			new Student("Sabrina", "Müller", 18),
			new Student("Anna", "Matt", 17),
			new Student("Peter", "Fredl", 18),
			new Student("Matthias", "Maier", 19)
		};

		foreach (var person in peopleInClassroom)
		{
			// First and lastname
			Console.WriteLine(person.ToString());

			if (person is Student s)
				Console.WriteLine(s.ListenToTeacher());
			else if (person is Teacher t)
				Console.WriteLine(t.Teach());
		}
	}
}