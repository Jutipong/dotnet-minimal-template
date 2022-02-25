using Api.Features.Todo.Repositories;

namespace Api.Features.Todo.Service;
public interface IService
{
    public Task<IList<EfModel.Todo>> GetTodosAsync();
    public Task<EfModel.Todo?> GetByIdAsync(Guid id);
    public Task<EfModel.Todo> CreateAsync(string title);
    public EfModel.Todo Update(TodoUpdateDto dto);
    public Task<bool> DeleteAsync(Guid id);
}