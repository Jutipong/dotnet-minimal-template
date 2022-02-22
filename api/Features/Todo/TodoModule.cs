using Carter;

namespace Api.Features.Todo;
public class TodoModule : ICarterModule
{
    // private readonly ITodoService _todoService;
    // public TodoModule(ITodoService service)
    // {
    //     this._todoService = service;
    // }

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/todos", (ITodoService _todoService) =>
        {
            return Results.Ok(_todoService.GetTodos());
        });

        app.MapGet("api/todo/{id}", (ITodoService _todoService, Guid id) =>
        {
            var result = _todoService.GetById(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        });

        app.MapPost("api/todo", (ITodoService _todoService, string title) =>
        {
            return Results.Ok(_todoService.Create(title));
        });

        app.MapPut("api/todo", (ITodoService _todoService, TodoUpdateDto dto) =>
        {
            var todo = _todoService.Update(dto);
            if (todo == null) return Results.NotFound();
            return Results.Ok(todo);
        });

        app.MapDelete("api/todo/{id}", (ITodoService _todoService, Guid id) =>
        {
            return _todoService.Delete(id)
            ? Results.Ok(true)
            : Results.NotFound();
        });
    }
}