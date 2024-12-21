namespace Bookify.Infrastructure.Authentication.Models;

public class CredentialRepresentationModel
{
    public string Algorithm { get; set; } = string.Empty;

    public string Config { get; set; } = string.Empty;

    public int Counter { get; set; }

    public long CreatedDate { get; set; }

    public string Device { get; set; } = string.Empty;

    public int Digits { get; set; }

    public int HashIterations { get; set; }

    public string HashedSaltedValue { get; set; } = string.Empty;

    public int Period { get; set; }

    public string Salt { get; set; } = string.Empty;

    public bool Temporary { get; set; }

    public string Type { get; set; } = string.Empty;

    public string Value { get; set; } = string.Empty;
}