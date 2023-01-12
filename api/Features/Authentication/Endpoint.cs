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
        }

        private IResult Login(AppSettings _appSettings, Request.Login user)
        {
            if (user.UserName != "admin" || user.Password != "1234") return Results.Unauthorized();

            var claims = new List<Claim>();
            claims.Add(new Claim("id", "99"));
            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.UserName));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(ClaimTypes.GivenName, "Super"));
            claims.Add(new Claim(ClaimTypes.Surname, "User"));
            string[] roles = new string[] { "admin", "dev" };

            foreach (var role in roles)
                claims.Add(new Claim("roles", role));

            var secureKey = Encoding.UTF8.GetBytes(_appSettings?.Jwt?.Key!);
            var issuer = _appSettings?.Jwt?.Issuer;//builder.Configuration["Jwt:Issuer"];
            var audience = _appSettings?.Jwt?.Audience;//builder.Configuration["Jwt:Audience"];
            var securityKey = new SymmetricSecurityKey(secureKey);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            //https://datatracker.ietf.org/doc/html/rfc7519#section-4.1.1
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