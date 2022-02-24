namespace Api.Features.Todo.Service;
public interface IService
{
    public ICollection<TodoModel> GetTodos();
    public TodoModel? GetById(Guid id);
    public TodoModel Create(string title);
    public TodoModel? Update(TodoUpdateDto dto);
    public bool Delete(Guid id);
}