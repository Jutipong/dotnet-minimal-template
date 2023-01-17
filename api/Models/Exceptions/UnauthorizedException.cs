namespace api.Compatible.Models.Exceptions;

public class UnauthorizedException : Exception
{
    public UnauthorizedException()
    {
    }

    public UnauthorizedException(string message) : base(message)
    {
    }

    public UnauthorizedException(OauthErrorCode errorCode) : base(errorCode.GetDescription())
    {
        ErrorCode = errorCode.GetNameToSnakeCase();
    }

    public string? ErrorCode { get; }
}