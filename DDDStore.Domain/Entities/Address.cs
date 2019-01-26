namespace DDDStore.Domain.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public void ChangeAddress(Address newAddress)
        {
            Street = newAddress.Street;
            Number = newAddress.Number;
            City = newAddress.City;
            State = newAddress.State;
            Country = newAddress.Country;
        }
    }
}
