using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using api.Features.Authentication.Dto;

using Microsoft.IdentityModel.Tokens;

namespace api.Features.Authentication
{
    public class Endpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/auth").WithTags("Auth");
            g.MapPost("/login", Login).AllowAnonymous();
            g.MapGet("/admin", [Authorize(Roles = "admin")] () => "Administrator");
            g.MapGet("/dev", [Authorize(Roles = "admin,dev")] () => "Developer");
            g.MapGet("/ceo", [Authorize(Roles = "ceo")] () => "CEO");
        }

        private IResult Login(AppSettings _appSettings, Request.Login user)
        {
            var users = new List<string> { "admin", "ceo" };

            if (!users.Contains(user.UserName) || user.Password != "1234") return Results.Unauthorized();

            var claims = new List<Claim>();
            claims.Add(new Claim("id", "99"));
            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.UserName));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(ClaimTypes.GivenName, "Super"));
            claims.Add(new Claim(ClaimTypes.Surname, "User"));

            var roles = user.UserName == "admin"
            ? new string[] { "admin", "dev" }
            : new string[] { "ceo" };

            foreach (var role in roles)
                claims.Add(new Claim("roles", role));

            var secureKey = Encoding.UTF8.GetBytes(_appSettings?.Jwt?.Key!);
            var issuer = _appSettings?.Jwt?.Issuer;
            var audience = _appSettings?.Jwt?.Audience;
            var securityKey = new SymmetricSecurityKey(secureKey);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(24),
                Audience = audience,
                Issuer = issuer,
                SigningCredentials = credentials
            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return Results.Ok(new Response { UserId = "99", UserName = user.UserName, Token = jwtToken });
        }
    }
}