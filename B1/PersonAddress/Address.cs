namespace PersonAddress
{
    public class Address
    {
        private int _id;
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int PostalCode { get; set; }
        public string? Country { get; set; }

        public bool Validate()
        { 
            return true; 
        } 
        
        public string OutputAsLabel()
        {
            return $"{Street}\n{PostalCode} {City}\n{Country}";
        }
    }
}
