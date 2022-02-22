namespace Api.Features.Todo;
public class TodoModel
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}

public record TodoUpdateDto(Guid Id, string Title);