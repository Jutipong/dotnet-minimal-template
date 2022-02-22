namespace Api.Features.Todo;
public class TodoModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}