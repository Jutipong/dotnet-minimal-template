namespace api.Models.Authentication;

public class Dto
{
    public class Login
    {
        [Required] public string UserName { get; set; } = string.Empty;

        [Required] public string Password { get; set; } = string.Empty;
    }
}