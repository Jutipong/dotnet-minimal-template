
using api.Features.Todo.Dto;

namespace api.Features.Todo.Service
{
    public class TodoService : ITodoService
    {
        public JsonResponse<Response.Create> Create(Request.CreateTodo create)
        {
            return new JsonResponse<Response.Create> { };
        }

        public JsonResponse<Response.Delete> Delete(Request.DeleteTodo delete)
        {
            return new JsonResponse<Response.Delete> { };
        }

        public JsonResponse<Response.Update> Update(Request.UpdateTodo update)
        {
            return new JsonResponse<Response.Update> { };
        }
    }
}
