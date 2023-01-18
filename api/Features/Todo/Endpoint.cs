using api.Models.Todo;

namespace api.Features.Todo;

public class TodoEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var groups = app.MapGroup("/todo").WithTags("Todos");
        groups.MapPost("/create", Create);
        groups.MapPut("/update", Update);
        groups.MapDelete("/delete/{id}", Delete);
    }

    private IResult Create(ITodoService _service, Dto.CreateTodo create)
    {
        return Results.Ok(_service.Create(create));
    }

    private IResult Update(ITodoService _service, Dto.UpdateTodo update)
    {
        return Results.Ok(_service.Update(update));
    }

    private IResult Delete(ITodoService _service, int id)
    {
        return Results.Ok(_service.Delete(new Dto.DeleteTodo { Id = id }));
    }
}