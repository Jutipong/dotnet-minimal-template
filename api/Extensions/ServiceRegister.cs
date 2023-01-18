using api.Features.Account;
using api.Features.Todo;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class ServiceCollection
{
    public static WebApplicationBuilder AddRegisterService(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAccountService, AccountService>();
        builder.Services.AddScoped<ITodoService, TodoService>();
        return builder;
    }
}