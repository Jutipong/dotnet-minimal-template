namespace api.Models.@Commons;

public class AppSettings
{
    public string? SystemID { get; set; }
    public string? AppName { get; set; }
    public string? AppVersion { get; set; }
    public bool Swagger { get; set; }
    public Jwt? Jwt { get; set; }
}

public class ConnectionStrings
{
    public string? DbContexts { get; set; }
}

public class Jwt
{
    public string? Issuer { get; set; }
    public string? Audience { get; set; }
    public string? Key { get; set; }
    public string? Secret { get; set; }
    public int ExpiryTimeInDay { get; set; }
}