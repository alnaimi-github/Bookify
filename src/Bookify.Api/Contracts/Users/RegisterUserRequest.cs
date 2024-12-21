namespace Bookify.Api.Contracts.Users;

public sealed record RegisterUserRequest(
    string Email,
    string FirstName,
    string LastName,
    string Password);