namespace Api.Features.Todo;
public class TodoModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/todos", async (Service.IService _service) =>
        {
            return Results.Ok(await _service.GetTodosAsync());
        });

        app.MapGet("api/todo/{id}", async (Service.IService _service, Guid id) =>
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        });

        app.MapPost("api/todo", async (Service.IService _service, string title) =>
        {
            return Results.Ok(await _service.CreateAsync(title));
        });

        app.MapPut("api/todo", async (Service.IService _service, TodoUpdateDto dto) =>
         {
             var todo = await _service.UpdateAsync(dto);
             if (todo == null) return Results.NotFound();
             return Results.Ok(todo);
         });

        app.MapDelete("api/todo/{id}", async (Service.IService _service, Guid id) =>
        {
            return await _service.DeleteAsync(id)
            ? Results.Ok(true)
            : Results.NotFound();
        });

        app.MapGet("api/todo/testinsert", async (Service.IService _service) =>
        {
            var res = await _service.TestInsert();
            return Results.Ok(res);
        });
    }
}