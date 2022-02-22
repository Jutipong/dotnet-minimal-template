using Carter;

namespace Api.Features.Todo;
public class TodoModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/todos", () =>
        {
            var response = new List<TodoModel> {
                new TodoModel{ Id= 1, Title= "Todo 1", IsActive = true},
                new TodoModel{ Id= 2, Title= "Todo 2", IsActive = true},
            };
            return Results.Ok(response);
        });
    }
}