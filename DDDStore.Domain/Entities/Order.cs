using System;
namespace DDDStore.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Discount { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public void UpdateDiscount(int discount)
        {
            Discount += discount;
        }
    }
}
