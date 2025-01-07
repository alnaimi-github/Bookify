namespace Bookify.Domain.Users.Entities;

public sealed class RolePermission
{
    public int RoleId { get; set; }

    public int PermissionId { get; set; }
}