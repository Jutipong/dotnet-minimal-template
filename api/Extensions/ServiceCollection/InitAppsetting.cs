namespace Microsoft.Extensions.DependencyInjection;

// using Microsoft.Data.Sqlite;

public static partial class ServiceCollection
{
    public static WebApplicationBuilder AddConfig(this WebApplicationBuilder builder)
    {
        var config = builder.Configuration;
        var appSettings = config.GetSection(nameof(AppSettings)).Get<AppSettings>();
        config.SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              //   .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
              //   .AddJsonFile("serilog.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables();

        builder.Services.AddSingleton(appSettings!);
        return builder;
    }
}
