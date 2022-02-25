using Api.Features.Todo.Repositories;

namespace Api.Features.Todo.Service;
public class Service : IService
{
    private ICollection<TodoModel> mock = new List<TodoModel>{
        new TodoModel{ Id= Guid.NewGuid(), Title= "Todo 1", IsActive = true},
        new TodoModel{ Id= Guid.NewGuid(), Title= "Todo 2", IsActive = true},
    };

    private readonly IRepositories _repo;
    public Service(IRepositories repo)
    {
        _repo = repo;
    }

    public async Task<IList<EfModel.Todo>> GetTodosAsync()
    {
        return await _repo.GetTodosAsync();
    }

    public async Task<EfModel.Todo?> GetByIdAsync(Guid id)
    {
        return await _repo.GetByidAsync(id);
    }

    public async Task<EfModel.Todo> CreateAsync(string title)
    {
        return await _repo.CreateAsync(new EfModel.Todo
        {
            Title = title,
            CreateDate = new DateTime(),
            CreateBy = "system",
        });
    }

    public async Task<EfModel.Todo?> UpdateAsync(TodoUpdateDto dto)
    {
        return await _repo.UpdateAsync(new EfModel.Todo
        {
            Id = dto.Id,
            Title = dto.Title
        });
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _repo.DeleteAsync(id);
    }
}