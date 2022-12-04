namespace Api.Features.Todo.Service;
public interface IService
{
    public Task<IList<Entity.Model.Todo>> GetTodosAsync();
    public Task<Entity.Model.Todo?> GetByIdAsync(Guid id);
    public Task<Entity.Model.Todo> CreateAsync(string title);
    public Task<Entity.Model.Todo?> UpdateAsync(TodoUpdateDto dto);
    public Task<bool> DeleteAsync(Guid id);
    public Task<string> TestInsert();
}