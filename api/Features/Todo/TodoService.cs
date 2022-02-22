namespace Api.Features.Todo;
public interface ITodoService
{
    public ICollection<TodoModel> GetTodos();
    public TodoModel? GetById(Guid id);
    public TodoModel Create(string title);
    public TodoModel? Update(TodoUpdateDto dto);
    public bool Delete(Guid id);
}

public class TodoService : ITodoService
{
    private ICollection<TodoModel> mock = new List<TodoModel>{
        new TodoModel{ Id= Guid.NewGuid(), Title= "Todo 1", IsActive = true},
        new TodoModel{ Id= Guid.NewGuid(), Title= "Todo 2", IsActive = true},
    };

    public ICollection<TodoModel> GetTodos()
    {
        return mock;
    }

    public TodoModel? GetById(Guid id)
    {
        var result = mock.FirstOrDefault(r => r.Id == id);
        return result;
    }

    public TodoModel Create(string title)
    {
        var create = new TodoModel
        {
            Id = Guid.NewGuid(),
            Title = title,
            IsActive = true
        };
        mock.Add(create);
        return create;
    }

    public TodoModel? Update(TodoUpdateDto dto)
    {
        var todo = mock.FirstOrDefault(r => r.Id == dto.Id);
        if (todo == null) return null;
        todo.Title = dto.Title;
        return todo;
    }

    public bool Delete(Guid id)
    {
        var todo = mock.FirstOrDefault(r => r.Id == id);
        if (todo == null) return false;
        mock.Remove(todo);
        return true;
    }
}