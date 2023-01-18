namespace api.Models.Todo;

public class Response
{
    public class Create
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Last { get; set; }
    }

    public class Update
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Last { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class Delete
    {
        public int Id { get; set; }
    }
}