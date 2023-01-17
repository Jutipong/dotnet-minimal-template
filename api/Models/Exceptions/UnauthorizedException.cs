namespace api.Compatible.Models.Exceptions;

public class UnauthorizedException : Exception
{
    public string? ErrorCode { get; private set; }

    public UnauthorizedException()
    {
    }

    public UnauthorizedException(string message) : base(message)
    {
    }

    public UnauthorizedException(OauthErrorCode errorCode)
        : base(errorCode.GetDescription())
    {
        ErrorCode = errorCode.GetNameToSnakeCase();
    }
}