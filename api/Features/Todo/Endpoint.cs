using api.Features.Todo.Service;
using static api.Features.Todo.Dto.Request;

namespace Web_Minimal.Features.Todo;

public class Endpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var groups = app.MapGroup("/todo").WithTags("Todos");
        groups.MapPost("/create", Create);
        groups.MapPut("/update", Update);
        groups.MapDelete("/delete/{id}", Delete);
    }

    private IResult Create(ITodoService _service, CreateTodo create)
    {
        return Results.Ok(_service.Create(create));
    }

    private IResult Update(ITodoService _service, UpdateTodo update)
    {
        return Results.Ok(_service.Update(update));
    }

    private IResult Delete(ITodoService _service, int id)
    {
        return Results.Ok(_service.Delete(new DeleteTodo { Id = id }));
    }
}