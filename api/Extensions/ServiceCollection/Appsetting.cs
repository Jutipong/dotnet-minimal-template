namespace Microsoft.Extensions.DependencyInjection;

public static partial class ServiceCollection
{
    public static WebApplicationBuilder AddConfig(this WebApplicationBuilder builder, string environment)
    {
        var configuration = builder.Configuration;
        var appSettings = configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();
        configuration.SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
                .AddJsonFile("serilog.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables();
        builder.Services.AddSingleton(appSettings!);
        return builder;
    }
}
