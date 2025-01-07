using System.Security;

namespace Bookify.Domain.Users.Entities;

public sealed class Role
{
    public static readonly Role Registered = new(1, "Registered");

    private Role(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; init; }

    public string Name { get; init; }

    public ICollection<User> Users { get; init; } = new List<User>();

    public ICollection<Permission> Permissions { get; init; } = new List<Permission>();
}
