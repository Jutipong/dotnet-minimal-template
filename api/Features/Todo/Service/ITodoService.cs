
using Web_Minimal.Features.Todo.Dto;

namespace Web_Minimal.Features.Todo.Service
{
    public interface ITodoService
    {
        public JsonResponse<Response.Create> Create(Request.CreateTodo create);
        public JsonResponse<Response.Update> Update(Request.UpdateTodo update);
        public JsonResponse<Response.Delete> Delete(Request.DeleteTodo delete);
    }
}
