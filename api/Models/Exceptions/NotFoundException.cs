namespace api.Compatible.Models.Exceptions;

public class NotFoundException : Exception
{
    public string? ErrorCode { get; private set; }

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
}