namespace Api.Features.Todo.Service;
public interface IService
{
    public Task<IList<Ef.Todo>> GetTodosAsync();
    public Task<Ef.Todo?> GetByIdAsync(Guid id);
    public Task<Ef.Todo> CreateAsync(string title);
    public Task<Ef.Todo?> UpdateAsync(TodoUpdateDto dto);
    public Task<bool> DeleteAsync(Guid id);
    public Task<string> TestInsert();
}