

namespace Creational_Patterns.Prototype
{
    public class Address
    {
        public string Building { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Address(string building, string street, string city, string country)
        {
            Building = building;
            Street = street;
            City = city;
            Country = country;
        }
    }
}
