using static Web_Minimal.Features.Todo.Dto.Request;
using Web_Minimal.Features.Todo.Service;

namespace Web_Minimal.Features.Todo
{
    public class Endpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var groups = app.MapGroup("/todo").WithTags("Todos").RequireAuthorization();

            groups.MapPost("/create", (ITodoService service, CreateTodo req) =>
            {
                return Results.Ok(service.Create(req));
            });

            groups.MapPut("/update", (ITodoService service, UpdateTodo req) =>
            {
                return Results.Ok(service.Update(req));
            });

            groups.MapDelete("/delete/{id}", (ITodoService service, int id) =>
            {
                return Results.Ok(service.Delete(new DeleteTodo { Id = id }));
            });
        }
    }
}
