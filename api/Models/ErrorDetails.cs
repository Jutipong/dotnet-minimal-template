using System.Text.Json.Serialization;

namespace api.Compatible.Models;

public class ErrorDetails
{
    [JsonPropertyName("error")]
    public string? Error { get; set; }
    [JsonPropertyName("error_description")]
    public string? ErrorDescription { get; set; }
}
