namespace Api.Features.Todo.Repositories;
public interface IRepositories
{
    public Task<IList<EfModel.Todo>> GetTodosAsync();
    public Task<EfModel.Todo?> GetByidAsync(Guid id);
    public Task<EfModel.Todo> CreateAsync(EfModel.Todo todo);
    public EfModel.Todo Update(EfModel.Todo todo);
    public Task<bool> DeleteAsync(Guid id);
}