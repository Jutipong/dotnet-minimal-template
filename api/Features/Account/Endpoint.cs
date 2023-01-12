using static Web_Minimal.Features.Account.Dto.Request;
using Web_Minimal.Features.Account.Service;
// using Microsoft.AspNetCore.Authorization;

namespace Web_Minimal.Features.Account
{
    public class Endpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/account").WithTags("Account");
            g.MapGet("/", () => "API => Account.").AllowAnonymous();
            g.MapPost("/create", Create);
            g.MapPut("/update", Update);
            g.MapDelete("/delete/{id}", Delete);
        }

        private IResult Create(IAccountService service, CreateAccount create) => Results.Ok(service.Create(create));

        private IResult Update(IAccountService service, UpdateAccount update) => Results.Ok(service.Update(update));

        private IResult Delete(IAccountService service, int id) => Results.Ok(service.Delete(new DeleteAccount { Id = id }));
    }
}
