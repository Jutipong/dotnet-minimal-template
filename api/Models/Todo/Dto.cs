namespace api.Models.Todo;

public class Dto
{
    public class CreateTodo
    {
        [Required] public string Name { get; set; } = string.Empty;

        [Required] public string Last { get; set; } = string.Empty;
    }

    public class UpdateTodo
    {
        [Required] public int Id { get; set; }

        [Required] public string Name { get; set; } = string.Empty;

        [Required] public string Last { get; set; } = string.Empty;
    }

    public class DeleteTodo
    {
        [Required] public int Id { get; set; }
    }
}