set host=localhost
set port=1433
set timeout=30
set dbname=Demo1
set user=sa
set password=p@ssw0rd

set context_name_space=Entity
set context_dir=.\Entity
set context_name=DBContexts

set name_space=Entity.Model
set output_dir=.\Entity\Model

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