using Api.Features.Todo.Repositories;

namespace Api.Features.Todo.Service;
public interface IService
{
    public Task<IList<EfModel.Todo>> GetTodosAsync();
    public Task<EfModel.Todo?> GetByIdAsync(Guid id);
    public Task<EfModel.Todo> CreateAsync(string title);
    public Task<EfModel.Todo?> UpdateAsync(TodoUpdateDto dto);
    public Task<bool> DeleteAsync(Guid id);
}