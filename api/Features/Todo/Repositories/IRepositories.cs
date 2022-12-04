namespace Api.Features.Todo.Repositories;
public interface IRepositories
{
    public Task<IList<Entity.Model.Todo>> GetTodosAsync();
    public Task<Entity.Model.Todo?> GetByidAsync(Guid id);
    public Task<Entity.Model.Todo> CreateAsync(Entity.Model.Todo todo);
    public Task<Entity.Model.Todo?> UpdateAsync(Entity.Model.Todo todo);
    public Task<bool> DeleteAsync(Guid id);

    public Task<string> TestInsert(List<Entity.Model.CustomerX> customers);
}