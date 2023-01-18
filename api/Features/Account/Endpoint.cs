using api.Models.Account;

namespace api.Features.Account;
public class AccountEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var g = app.MapGroup("/account").WithTags("Account").AllowAnonymous();
        g.MapGet("/", () => "API => Account.").AllowAnonymous();
        g.MapGet("/exception", () => { throw new InvalidOperationException("Sample Exception"); });
        g.MapPost("/create", Create).AllowAnonymous();
        g.MapPut("/update", Update);
        g.MapDelete("/delete/{id}", Delete);
    }

    private IResult Create(ILogger<Endpoint> _log, IAccountService service, Dto.CreateAccount create)
    {
        _log.LogInformation("params: {@Create}", create);
        var result = service.Create(create);
        _log.LogInformation("===== end Endpoint =====");

        // //mack err
        // result = null;
        // var tt = result.Datas.Id;

        return Results.Ok(result);
    }

    private IResult Update(IAccountService service, Dto.UpdateAccount update)
    {
        return Results.Ok(service.Update(update));
    }

    private IResult Delete(IAccountService service, int id)
    {
        return Results.Ok(service.Delete(new Dto.DeleteAccount { Id = id }));
    }
}