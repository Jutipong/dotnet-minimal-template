// using Web_Minimal.Features.Todo.Service;

// namespace Web_Minimal.Features.Todo
// {
//     public class Endpoint : ICarterModule
//     {
//         public void AddRoutes(IEndpointRouteBuilder app)
//         {
//             var groups = app.MapGroup("/todo").WithTags("Todos").RequireAuthorization();

//             groups.MapPost("/create1", (ITodoService service, Dto.Request.CreateTodo req) =>
//             {
//                 return Results.Ok(service.Create(req));
//             });

//             groups.MapPut("/update2", (ITodoService service, Dto.Request.UpdateTodo req) =>
//             {
//                 return Results.Ok(service.Update(req));
//             });

//             groups.MapDelete("/delete3/{id}", (ITodoService service, int id) =>
//             {
//                 return Results.Ok(service.Delete(new Dto.Request.DeleteTodo { Id = id }));
//             });
//         }
//     }
// }
