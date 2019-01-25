using System;
using System.Collections.Generic;

namespace DDDStore.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }
    }
}
