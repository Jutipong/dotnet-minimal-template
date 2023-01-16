using static Web_Minimal.Features.Account.Dto.Request;
using Web_Minimal.Features.Account.Service;
using System.Text.Json;
// using Microsoft.AspNetCore.Authorization;

namespace Web_Minimal.Features.Account
{
    public class Endpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/account").WithTags("Account").AllowAnonymous();
            g.MapGet("/", () => "API => Account.").AllowAnonymous();
            g.MapPost("/create", Create).AllowAnonymous();
            g.MapPut("/update", Update);
            g.MapDelete("/delete/{id}", Delete);
        }

        private IResult Create(ILogger<Endpoint> _log, IAccountService service, CreateAccount create)
        {
            try
            {
                _log.LogInformation("params: {@Create}", create);
                var result = service.Create(create);
                _log.LogInformation("===== end Endpoint =====");

                // //mack err
                // result = null;
                // var tt = result.Datas.Id;

                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                _log.LogError("Error: {@Ex}", ex);
                return Results.NotFound();
            }
        }

        private IResult Update(IAccountService service, UpdateAccount update) => Results.Ok(service.Update(update));

        private IResult Delete(IAccountService service, int id) => Results.Ok(service.Delete(new DeleteAccount { Id = id }));
    }
}
