namespace Models
{
    public class AppSittingModel
    {
        // public string SystemID { get; set; }
        // public string AppName { get; set; }
        // public string AppVersion { get; set; }
        // public JwtModel Jwt { get; set; }
        public ConnectionStringModel ConnectionStrings { get; set; } = new ConnectionStringModel();
    }
    public class ConnectionStringModel
    {
        public string? AppContext { get; set; } = string.Empty;
    }
}