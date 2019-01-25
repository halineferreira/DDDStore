using System;
namespace DDDStore.Domain.Entities
{
    public class Phone
    {
        public int Id { get; set; }
        public string CodeArea { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
