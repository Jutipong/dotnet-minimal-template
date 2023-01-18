using System.Text.Json.Serialization;

namespace api.Models.@Exceptions;

public class ErrorDetails
{
    [JsonPropertyName("error")]
    public string? Error { get; set; }
    [JsonPropertyName("error_description")]
    public string? ErrorDescription { get; set; }
}
