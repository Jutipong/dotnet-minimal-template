
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class ServiceCollection
{
    public static WebApplicationBuilder AddAuthentication(this WebApplicationBuilder builder)
    {
        AddAuthentication(builder.Services);
        return builder;
    }
    public static WebApplicationBuilder AddAuthorization(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthorization(options =>
        {
            options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
        });
        return builder;
    }

    private static IServiceCollection AddAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.Authority = "https://login.microsoftonline.com/xxxxxxxxxxxxxxxxxxxxxxxxxx";
            options.Audience = "xxxxxxxxxxxxxxxxxxxxxxxxx";
            options.TokenValidationParameters.ValidateLifetime = false; //Production have to be true,
            options.TokenValidationParameters.ClockSkew = TimeSpan.Zero;
        });

        return services;
    }
}
