namespace Features.Todo.Repositories;
public interface IRepositories
{
    public Task<IList<Entity.Models.Todo>> GetTodosAsync();
    public Task<Entity.Models.Todo?> GetByidAsync(Guid id);
    public Task<Entity.Models.Todo> CreateAsync(Entity.Models.Todo todo);
    public Task<Entity.Models.Todo?> UpdateAsync(Entity.Models.Todo todo);
    public Task<bool> DeleteAsync(Guid id);

    public Task<string> TestInsert(List<Entity.Models.CustomerX> customers);
}