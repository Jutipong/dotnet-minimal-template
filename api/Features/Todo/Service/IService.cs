namespace Features.Todo.Service;
public interface IService
{
    public Task<IList<Entity.Models.Todo>> GetTodosAsync();
    public Task<Entity.Models.Todo?> GetByIdAsync(Guid id);
    public Task<Entity.Models.Todo> CreateAsync(string title);
    public Task<Entity.Models.Todo?> UpdateAsync(TodoUpdateDto dto);
    public Task<bool> DeleteAsync(Guid id);
    public Task<string> TestInsert();
}