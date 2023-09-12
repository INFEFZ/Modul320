namespace PersonAddress
{
    public class Person
    {
        private long _id;
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }

        public Address LivesAt { get; set; } = new Address();

        public void PurchaseParkingPass()
        {
            string output = $"{Name}\n{EmailAddress}\n{LivesAt.OutputAsLabel()}";
            Console.WriteLine(output);
        }
    }
}
