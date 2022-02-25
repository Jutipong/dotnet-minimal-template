using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
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


    // public class AppSittingModel
    // {
    //     public class ConnectionString
    //     {
    //         public string AppContext { get; } = string.Empty;
    //     }
    // }
}