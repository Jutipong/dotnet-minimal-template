namespace Microsoft.Extensions.DependencyInjection;

public static partial class ServiceCollection
{
    public static WebApplicationBuilder AddDAtaBase(this WebApplicationBuilder builder)
    {
        // builder.Services.AddScoped(_ => new SqliteConnection("Data Source=todos.db"));

        return builder;
    }
}