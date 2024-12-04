namespace Bookify.Domain.Apartments.ValueObjects;

public record Address(
    string Country,
    string State,
    string City,
    string ZipCode,
    string Street);