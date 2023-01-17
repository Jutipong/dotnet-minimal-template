namespace api.Compatible.Models.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException()
    {
    }

    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(OauthErrorCode errorCode)
        : base(errorCode.GetDescription())
    {
        ErrorCode = errorCode.GetNameToSnakeCase();
    }

    public string? ErrorCode { get; }
}