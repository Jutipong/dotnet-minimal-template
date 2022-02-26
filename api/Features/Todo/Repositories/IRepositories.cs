namespace Api.Features.Todo.Repositories;
public interface IRepositories
{
    public Task<IList<Ef.Todo>> GetTodosAsync();
    public Task<Ef.Todo?> GetByidAsync(Guid id);
    public Task<Ef.Todo> CreateAsync(Ef.Todo todo);
    public Task<Ef.Todo?> UpdateAsync(Ef.Todo todo);
    public Task<bool> DeleteAsync(Guid id);
}