namespace Microsoft.AspNetCore.Builder;

internal static partial class ApplicationBuilder
{
    /// <summary>
    /// Register Swagger endpoints.
    /// </summary>
    public static IApplicationBuilder UseSwaggerEndpoints(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API");
            c.RoutePrefix = string.Empty;
        });

        return app;
    }
}
