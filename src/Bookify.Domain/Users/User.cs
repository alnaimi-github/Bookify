using Bookify.Domain.Abstractions;
using Bookify.Domain.Users.Events;
using Bookify.Domain.Users.ValueObjects;

namespace Bookify.Domain.Users;

public sealed class User : Entity
{
    public FirstName FirstName { get;private set; }
    public LastName LastName { get;private set; }
    public Email Email { get;private set; }
    public string IdentityId { get; private set; } = string.Empty;
    private User(
        Guid id, 
        FirstName firstName,
        LastName lastName,
        Email email) 
        : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    private User()
    {

    }

    public static User Create(
        FirstName firstName,
        LastName lastName,
        Email email)
    {
        var user = new User(
            Guid.NewGuid(),
            firstName,
            lastName,
            email);
        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }

    public void SetIdentityId(string identityId)
    {
        IdentityId = identityId;
    }
}