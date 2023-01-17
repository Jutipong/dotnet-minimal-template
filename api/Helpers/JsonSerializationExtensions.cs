using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace api.Compatible.Helpers;

public static class JsonSerializationHelpers
{
    private static readonly SnakeCaseNamingStrategy _snakeCaseNamingStrategy = new();

    private static readonly JsonSerializerSettings _snakeCaseSettings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = _snakeCaseNamingStrategy
        }
    };

    public static string ToSnakeCase<T>(this T instance)
    {
        if (instance == null) throw new ArgumentNullException(nameof(instance));

        return JsonConvert.SerializeObject(instance, _snakeCaseSettings);
    }

    public static string ToSnakeCase(this string? @string)
    {
        if (@string == null) throw new ArgumentNullException(nameof(@string));

        return _snakeCaseNamingStrategy.GetPropertyName(@string, false);
    }
}