namespace DDDStore.Domain.Entities
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string CodeArea { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public void ChangePhone(Phone newPhone)
        {
            CodeArea = newPhone.CodeArea;
            Number = newPhone.Number;
        }
    }
}
