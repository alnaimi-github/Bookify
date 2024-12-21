namespace Bookify.Api.Contracts.Users;

public sealed record LogInUserRequest(string Email, string Password);