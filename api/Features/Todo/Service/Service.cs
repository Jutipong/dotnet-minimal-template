using Api.Features.Todo.Repositories;

namespace Api.Features.Todo.Service;
public class Service : IService
{
    private readonly IRepositories _repo;
    public Service(IRepositories repo)
    {
        _repo = repo;
    }

    public async Task<IList<Ef.Todo>> GetTodosAsync()
    {
        return await _repo.GetTodosAsync();
    }

    public async Task<Ef.Todo?> GetByIdAsync(Guid id)
    {
        return await _repo.GetByidAsync(id);
    }

    public async Task<Ef.Todo> CreateAsync(string title)
    {
        return await _repo.CreateAsync(new Ef.Todo
        {
            Title = title,
            CreateDate = new DateTime(),
            CreateBy = "system",
        });
    }

    public async Task<Ef.Todo?> UpdateAsync(TodoUpdateDto dto)
    {
        return await _repo.UpdateAsync(new Ef.Todo
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
        var datas = new List<Ef.CustomerX>();
        for (int i = 0; i < 500000; i++)
        {
            datas.Add(new Ef.CustomerX
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