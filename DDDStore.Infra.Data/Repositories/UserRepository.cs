using DDDStore.Domain.Entities;
using DDDStore.Domain.Interfaces.Repositories;

namespace DDDStore.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {

    }
}
