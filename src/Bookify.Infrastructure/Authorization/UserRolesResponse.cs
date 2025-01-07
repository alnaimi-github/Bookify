using Bookify.Domain.Users.Entities;

namespace Bookify.Infrastructure.Authorization;

public class UserRolesResponse
{
    public Guid UserId { get; init; }

    public List<Role> Roles { get; init; } = [];
}