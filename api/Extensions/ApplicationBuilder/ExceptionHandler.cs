using api.Compatible.Helpers;
using api.Models.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace Microsoft.AspNetCore.Builder;

internal static partial class ApplicationBuilder
{
    public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder app,
        IWebHostEnvironment environment)
    {
        if (environment.IsDevelopment()) app.UseDeveloperExceptionPage();

        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.ContentType = "application/json";
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature != null)
                {
                    context.Response.StatusCode = contextFeature.Error switch
                    {
                        BadRequestException => (int)HttpStatusCode.BadRequest,
                        NotFoundException => (int)HttpStatusCode.NotFound,
                        UnauthorizedException => (int)HttpStatusCode.Unauthorized,
                        _ => (int)HttpStatusCode.InternalServerError
                    };
                    var errorException = contextFeature.Error;

                    // Serilog.Log.Logger.Error("{@errorException}", errorException);

                    await context.Response.WriteAsync(new ErrorDetails
                    {
                        Error = errorException.GetType().GetProperty("ErrorCode")?.GetValue(errorException)?.ToString() ?? "exception",
                        ErrorDescription = errorException.Message
                    }.ToSnakeCase());
                }
            });
        });
        return app;
    }
}