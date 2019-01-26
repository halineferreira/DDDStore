using DDDStore.Domain.Entities;
using DDDStore.Domain.Interfaces.Repositories;

namespace DDDStore.Infra.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {

    }
}
