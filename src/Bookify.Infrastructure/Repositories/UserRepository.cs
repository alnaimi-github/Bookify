using Bookify.Domain.Users.Interfaces;
using Bookify.Domain.Users;
using System.Data;

namespace Bookify.Infrastructure.Repositories;

internal sealed class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext)
    : base(dbContext)
    {
    }

}