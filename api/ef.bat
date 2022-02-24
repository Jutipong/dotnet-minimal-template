set host=localhost 
set port=1433
set timeout=30
set dbname=demo1
set user=sa
set password=p@ssw0rd
set context_name=DbContexts
set context_dir=.\Entities 
set output_dir=.\Entities\Models

dotnet ef dbcontext scaffold "Server=%host%,%port%;Initial Catalog=%dbname%;User ID=%user%; Password=%password%; Timeout=%timeout%;" ^
Microsoft.EntityFrameworkCore.SqlServer ^
--use-database-names ^
--data-annotations ^
--no-onconfiguring ^
--context %context_name% ^
--context-dir %context_dir% ^
--output-dir %output_dir% ^
--force