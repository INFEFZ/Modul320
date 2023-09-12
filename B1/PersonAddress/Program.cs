namespace PersonAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person max = new Person();
            max.Name = "Max";
            max.EmailAddress = "max.muster@ipso.ch";

            Address address = new Address();
            address.Street = "Elisabethenanlage 9";
            address.PostalCode = 4000;
            address.City = "Basel";
            address.Country = "Switzerland";

            // Adresse zuweisen
            max.LivesAt = address;

            // Parking
            max.PurchaseParkingPass();

            Console.WriteLine("Weiter mit <ENTER>");
        }
    }
}