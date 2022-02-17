using Carter;

namespace Api.Features.Todo
{
    public class TodoModule : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/todos", () =>
            {
                return "OKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK";
            });

        }
    }
}