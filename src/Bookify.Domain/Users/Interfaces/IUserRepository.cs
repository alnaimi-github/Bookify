namespace Bookify.Domain.Users.Interfaces;

public interface IUserRepository
{
    Task<bool> AddAsync(User user, CancellationToken cancellationToken = default);
    Task<User?> GetByIdAsync(Guid id,CancellationToken cancellationToken= default);
}