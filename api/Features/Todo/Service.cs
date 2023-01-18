using api.Models.Todo;

namespace api.Features.Todo;

public interface ITodoService
{
    public JsonResponse<Response.Create> Create(Dto.CreateTodo create);
    public JsonResponse<Response.Update> Update(Dto.UpdateTodo update);
    public JsonResponse<Response.Delete> Delete(Dto.DeleteTodo delete);
}


public class TodoService : ITodoService
{
    public JsonResponse<Response.Create> Create(Dto.CreateTodo create)
    {
        return new JsonResponse<Response.Create>();
    }

    public JsonResponse<Response.Delete> Delete(Dto.DeleteTodo delete)
    {
        return new JsonResponse<Response.Delete>();
    }

    public JsonResponse<Response.Update> Update(Dto.UpdateTodo update)
    {
        return new JsonResponse<Response.Update>();
    }
}