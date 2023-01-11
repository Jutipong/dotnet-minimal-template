
using Web_Minimal.Features.Todo.Dto;

namespace Web_Minimal.Features.Todo.Service
{
    public class TodoService : ITodoService
    {
        public JsonResponse<Response.Create> Create(Request.CreateTodo create)
        {
            throw new NotImplementedException();
        }

        public JsonResponse<Response.Delete> Delete(Request.DeleteTodo delete)
        {
            throw new NotImplementedException();
        }

        public JsonResponse<Response.Update> Update(Request.UpdateTodo update)
        {
            throw new NotImplementedException();
        }
    }
}
