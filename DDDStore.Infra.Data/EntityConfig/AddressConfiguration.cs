using System.Data.Entity.ModelConfiguration;
using DDDStore.Domain.Entities;

namespace DDDStore.Infra.Data.EntityConfig
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(a => a.AddressId);

            Property(a => a.Street)
                .IsRequired();

            Property(a => a.Number)
                .IsRequired();

            Property(a => a.Street)
                .IsRequired();

            Property(a => a.City)
                .IsRequired();

            Property(a => a.State)
                .IsRequired();

            Property(a => a.Country)
                .IsRequired();

            HasRequired(a => a.Customer)
                .WithMany()
                .HasForeignKey(a => a.CustomerId);
        }
    }
}
