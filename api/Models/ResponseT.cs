namespace api.Models;

public class JsonResponse<T>
{
    public string? Message { get; set; }
    public string? Error { get; set; }
    public T? Datas { get; set; }
}