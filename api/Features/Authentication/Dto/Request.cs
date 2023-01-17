namespace api.Features.Authentication.Dto;

public class Request
{
    public class Login
    {
        [Required] public string UserName { get; set; } = string.Empty;

        [Required] public string Password { get; set; } = string.Empty;
    }
}