using Serilog;
using Serilog.Events;
using Serilog.Sinks.SpectreConsole;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class ServiceCollection
{
    public static WebApplicationBuilder AddSerilog(this WebApplicationBuilder builder)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.SpectreConsole("{Timestamp:HH:mm:ss} [{Level:u4}] {Message:lj}{NewLine}{Exception}", minLevel: LogEventLevel.Information).CreateLogger();

        builder.Host.UseSerilog((hostContext, loggerConfig) =>
        {
            loggerConfig.WriteTo.Console();
        });

        return builder;
    }
}
