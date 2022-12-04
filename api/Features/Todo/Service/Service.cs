using Api.Features.Todo.Repositories;

namespace Api.Features.Todo.Service;
public class Service : IService
{
    private readonly IRepositories _repo;
    public Service(IRepositories repo)
    {
        _repo = repo;
    }

    public async Task<IList<Entity.Model.Todo>> GetTodosAsync()
    {
        return await _repo.GetTodosAsync();
    }

    public async Task<Entity.Model.Todo?> GetByIdAsync(Guid id)
    {
        return await _repo.GetByidAsync(id);
    }

    public async Task<Entity.Model.Todo> CreateAsync(string title)
    {
        return await _repo.CreateAsync(new Entity.Model.Todo
        {
            Title = title,
            CreateDate = new DateTime(),
            CreateBy = "system",
        });
    }

    public async Task<Entity.Model.Todo?> UpdateAsync(TodoUpdateDto dto)
    {
        return await _repo.UpdateAsync(new Entity.Model.Todo
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
        var datas = new List<Entity.Model.CustomerX>();
        for (int i = 0; i < 500000; i++)
        {
            datas.Add(new Entity.Model.CustomerX
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