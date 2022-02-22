using Carter;

namespace Api.Features.Todo;
public class TodoModule : ICarterModule
{
    private List<TodoModel> mock = new List<TodoModel>{
        new TodoModel{ Id= Guid.NewGuid(), Title= "Todo 1", IsActive = true},
        new TodoModel{ Id= Guid.NewGuid(), Title= "Todo 2", IsActive = true},
    };
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/todos", () => Results.Ok(mock));

        app.MapGet("api/todo/{id}", (Guid id) =>
        {
            var result = mock.FirstOrDefault(r => r.Id == id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        });

        app.MapPost("api/todo", (string title) =>
        {
            var create = new TodoModel
            {
                Id = Guid.NewGuid(),
                Title = title,
                IsActive = true
            };
            mock.Add(create);
            return Results.Ok(create);
        });

        app.MapPut("api/todo", (TodoUpdateDto dto) =>
        {
            var todo = mock.FirstOrDefault(r => r.Id == dto.Id);
            if (todo == null) return Results.NotFound();
            todo.Title = dto.Title;
            return Results.Ok(todo);
        });

        app.MapDelete("api/todo/{id}", (Guid id) =>
        {
            var todo = mock.FirstOrDefault(r => r.Id == id);
            if (todo == null) return Results.NotFound();
            mock.Remove(todo);
            return Results.Ok(true);
        });
    }
}