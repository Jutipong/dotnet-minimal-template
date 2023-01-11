using Web_Minimal.Features.Account.Service;

namespace Microsoft.Extensions.DependencyInjection;
public static partial class ServiceCollection
{
    public static WebApplicationBuilder RepositoryRegister(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAccountService, AccountService>();
        return builder;
    }

}