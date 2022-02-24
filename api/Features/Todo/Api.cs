using Carter;

namespace Api.Features.Todo;
public class TodoModule : ICarterModule
{
    // private readonly ITodoService _service;
    // public TodoModule(ITodoService service)
    // {
    //     this._service = service;
    // }

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/todos", (Service.IService _service) =>
        {
            return Results.Ok(_service.GetTodos());
        });

        app.MapGet("api/todo/{id}", (Service.IService _service, Guid id) =>
        {
            var result = _service.GetById(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        });

        app.MapPost("api/todo", (Service.IService _service, string title) =>
        {
            return Results.Ok(_service.Create(title));
        });

        app.MapPut("api/todo", (Service.IService _service, TodoUpdateDto dto) =>
        {
            var todo = _service.Update(dto);
            if (todo == null) return Results.NotFound();
            return Results.Ok(todo);
        });

        app.MapDelete("api/todo/{id}", (Service.IService _service, Guid id) =>
        {
            return _service.Delete(id)
            ? Results.Ok(true)
            : Results.NotFound();
        });
    }
}