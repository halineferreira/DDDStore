using System;
namespace DDDStore.Domain.Entities
{
    public class Order
    {
        public int id { get; set; }
        public Customer customer { get; set; }
        public Address address { get; set; }
        public int discount { get; set; }
    }
}
