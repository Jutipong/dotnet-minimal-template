using api.Compatible.Helpers;

namespace api.Models.@Exceptions;

public enum OauthErrorCode
{
    InvalidRequest,
    InvalidHeadersAuthorization,
    InvalidClientId,
    InvalidClientCredentials,
    InvalidGrant,
    InvalidUsernamePassword,
    InvalidTokenType,
    InvalidToken,
    InvalidTokenPattern,
    InvalidTokenExpired,
    InvalidRequestType,
    NoAccess
}

public static class OauthError
{
    private static readonly Dictionary<OauthErrorCode, string> OauthErrorDescriptions =
        new()
        {
            { OauthErrorCode.InvalidRequest, "Request parameter {0} is required" },
            { OauthErrorCode.InvalidHeadersAuthorization, "Headers is require property \"Authorization\"" },
            { OauthErrorCode.InvalidClientId, "Invalid \"client_id\"" },
            { OauthErrorCode.InvalidClientCredentials, "Invalid \"client_id\" or \"client_secret\"" },
            { OauthErrorCode.InvalidGrant, "Invalid grant type is not support." },
            { OauthErrorCode.InvalidUsernamePassword, "Invalid \"username\" or \"password\"" },
            { OauthErrorCode.InvalidTokenType, "Invalid \"token_type\"" },
            { OauthErrorCode.InvalidToken, "The access token is invalid" },
            { OauthErrorCode.InvalidTokenPattern, "The access token is incorrect pattern" },
            { OauthErrorCode.InvalidTokenExpired, "The access token has expired" },
            { OauthErrorCode.InvalidRequestType, "Request parameter type allow only values : [employeeid, aduser]" },
            { OauthErrorCode.NoAccess, "You don't have permission to access" }
        };

    public static string GetDescription(this OauthErrorCode errorCode)
    {
        return OauthErrorDescriptions.TryGetValue(errorCode, out var description) ? description : "Unknown";
    }

    public static string GetNameToSnakeCase(this OauthErrorCode errorCode)
    {
        return Enum.GetName(errorCode).ToSnakeCase();
    }
}