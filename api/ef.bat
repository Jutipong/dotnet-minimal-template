set host=localhost
set port=1433
set timeout=30
set dbname=Demo1
set user=sa
set password=p@ssw0rd

set context_name_space=Api.Entities
set context_dir=.\Entities
set context_name=DbContexts

set name_space=Api.Entities.Models
set output_dir=.\Entities\Models

dotnet ef dbcontext scaffold "Server=%host%,%port%;Initial Catalog=%dbname%;User ID=%user%; Password=%password%; Timeout=%timeout%; TrustServerCertificate=true;" ^
Microsoft.EntityFrameworkCore.SqlServer ^
--use-database-names ^
--data-annotations ^
--no-onconfiguring ^
--context-dir %context_dir% ^
--context %context_name% ^
--context-namespace %context_name_space% ^
--namespace %name_space% ^
--output-dir %output_dir% ^
--force