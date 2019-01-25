using System.Data.Entity.ModelConfiguration;
using DDDStore.Domain.Entities;

namespace DDDStore.Infra.Data.EntityConfig
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(c => c.CustomerId);

            Property(c => c.Title)
                .IsRequired();

            Property(c => c.FirstName)
                .IsRequired();

            Property(c => c.LastName)
                .IsRequired();

            Property(c => c.Email)
                .IsRequired();

        }
    }
}
