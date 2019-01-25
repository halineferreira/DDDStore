using System;
using System.Collections.Generic;

namespace DDDStore.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual IEnumerable<Address> Addresses { get; set; }
        public virtual IEnumerable<Phone> Phones { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public bool AutoCommunication { get; set; }
    }
}
