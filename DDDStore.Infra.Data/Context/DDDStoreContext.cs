using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DDDStore.Domain.Entities;
using DDDStore.Infra.Data.EntityConfig;

namespace DDDStore.Infra.Data.Context
{
    public class DDDStoreContext : DbContext
    {
        public DDDStoreContext()
            : base("DDDStore")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
        }
    }
}
