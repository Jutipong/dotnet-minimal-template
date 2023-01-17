
namespace Api.Models.Exceptions;

public class BadRequestException : Exception
{
    public string? ErrorCode { get; private set; }

    public BadRequestException()
    {
    }

    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, Exception inner)
        : base(message, inner)
    {
    }

    // public BadRequestException(OauthErrorCode errorCode)
    //     : base(errorCode.GetDescription())
    // {
    //     ErrorCode = errorCode.GetNameToSnakeCase();
    // }

    // public BadRequestException(OauthErrorCode errorCode, string[] fieldName)
    //     : base(GetMessageReplaceParameter(errorCode, fieldName))
    // {
    //     ErrorCode = errorCode.GetNameToSnakeCase();
    // }

    // private static string GetMessageReplaceParameter(OauthErrorCode errorCode, string[] fieldName)
    // {
    //     var message = errorCode.GetDescription();
    //     return message.Replace("{0}", string.Join(",", fieldName.ToSnakeCase()));
    // }
}