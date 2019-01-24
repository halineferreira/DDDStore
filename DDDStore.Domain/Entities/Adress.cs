using System;
namespace DDDStore.Domain.Entities
{
    public class Adress
    {
        public int id { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }
}
