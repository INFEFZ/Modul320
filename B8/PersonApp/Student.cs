namespace PersonApp
{
	public class Student : Person
	{
		public Student(string firstName, string lastName, int age) 
			: base(firstName, lastName, age)
		{
		}

		public string ListenToTeacher()
		{
			return $"Der/Die Schüler/in {FirstName} {LastName} hört dem Lehrer zu!";
		}
	}
}
