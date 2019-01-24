using System;
namespace DDDStore.Domain.Entities
{
    public class Customer
    {
        public int id { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Address> addresses { get; set; }
        public List<Phone> phones { get; set; }
        public string email { get; set; }
        public int points { get; set; }
        public Category category { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool autoCommunication { get; set; }
    }
}
