using System.Diagnostics;

namespace Api.Features.Todo.Repositories;
public class Repositories : IRepositories
{
    private readonly DbContexts _db;
    public Repositories(DbContexts db)
    {
        _db = db;
    }

    public async Task<IList<Ef.Todo>> GetTodosAsync()
    {
        return await _db.Todos.ToListAsync();
    }

    public async Task<Ef.Todo?> GetByidAsync(Guid id)
    => await _db.Todos.FirstOrDefaultAsync(r => r.Id == id);

    public async Task<Ef.Todo> CreateAsync(Ef.Todo todo)
    {
        await _db.Todos.AddAsync(todo);
        await _db.SaveChangesAsync();
        return todo;
    }


    public async Task<Ef.Todo?> UpdateAsync(Ef.Todo todo)
    {
        var data = await _db.Todos.FirstOrDefaultAsync(r => r.Id == todo.Id);
        if (data == null) return null;

        data.Title = todo.Title;
        data.UpdateDate = DateTime.Now;
        _db.Todos.Update(data);
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


    public async Task<string> TestInsert(List<Ef.CustomerX> customers)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        await _db.AddRangeAsync(customers);
        await _db.SaveChangesAsync();

        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value. 
        var elapsedTime = String.Format("insert data: {0} {1:00}:{2:00}:{3:00}.{4:00}", customers.Count,
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

        Console.WriteLine(elapsedTime);
        return elapsedTime;
    }
}