using System.Data.Entity;

namespace DDDStore.Infra.Data.Context
{
    public class DDDStoreContext : DbContext
    {
        public DDDStoreContext()
            : base("DDDStore")
        {

        }

        public DbSet<Customer> customers { get; set; }
    }
}
