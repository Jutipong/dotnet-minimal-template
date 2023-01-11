using Web_Minimal.Features.Account.Service;

namespace Web_Minimal.Features.Account
{
    public class Endpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var groups = app.MapGroup("/account").WithTags("Account");

            groups.MapPost("/create", (IAccountService service, Dto.Request.CreateAccount req) =>
            {
                return Results.Ok(service.Create(req));
            });

            groups.MapPut("/update", (IAccountService service, Dto.Request.UpdateAccount req) =>
            {
                return Results.Ok(service.Update(req));
            });

            groups.MapDelete("/delete/{id}", (IAccountService service, int id) =>
            {
                return Results.Ok(service.Delete(new Dto.Request.DeleteAccount { Id = id }));
            }).RequireAuthorization();
        }
    }
}
