using Features.Todo.Repositories;

namespace Features.Todo.Service;
public class Service : IService
{
    private readonly IRepositories _repo;
    public Service(IRepositories repo)
    {
        _repo = repo;
    }

    public async Task<IList<Entity.Models.Todo>> GetTodosAsync()
    {
        return await _repo.GetTodosAsync();
    }

    public async Task<Entity.Models.Todo?> GetByIdAsync(Guid id)
    {
        return await _repo.GetByidAsync(id);
    }

    public async Task<Entity.Models.Todo> CreateAsync(string title)
    {
        return await _repo.CreateAsync(new Entity.Models.Todo
        {
            Title = title,
            CreateDate = new DateTime(),
            CreateBy = "system",
        });
    }

    public async Task<Entity.Models.Todo?> UpdateAsync(TodoUpdateDto dto)
    {
        return await _repo.UpdateAsync(new Entity.Models.Todo
        {
            Id = dto.Id,
            Title = dto.Title
        });
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _repo.DeleteAsync(id);
    }

    public async Task<string> TestInsert()
    {
        var datas = new List<Entity.Models.CustomerX>();
        for (int i = 0; i < 500000; i++)
        {
            datas.Add(new Entity.Models.CustomerX
            {
                Id = Guid.NewGuid().ToString(),
                Age = i,
                Name = $"Name: {i}",
                Email = $"Email: {i}",
                IsActive = true
            });
        }
        return await _repo.TestInsert(datas);
    }
}