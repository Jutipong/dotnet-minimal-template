namespace Api.Features.Todo.Repositories;
public class Repositories : IRepositories
{
    private readonly DbContexts _db;
    public Repositories(DbContexts db)
    {
        _db = db;
    }

    public async Task<IList<EfModel.Todo>> GetTodosAsync()
    {
        return await _db.Todos.ToListAsync();
    }

    public async Task<EfModel.Todo?> GetByidAsync(Guid id)
    => await _db.Todos.FirstOrDefaultAsync(r => r.Id == id);

    public async Task<EfModel.Todo> CreateAsync(EfModel.Todo todo)
    {
        await _db.Todos.AddAsync(todo);
        await _db.SaveChangesAsync();
        return todo;
    }


    public EfModel.Todo Update(EfModel.Todo todo)
    {
        _db.Todos.Update(todo);
        _db.SaveChanges();
        return todo;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var todo = await _db.Todos.FirstOrDefaultAsync(r => r.Id == id);
        if (todo == null) return false;
        _db.Remove(todo);
        _db.SaveChanges();
        return true;
    }
}