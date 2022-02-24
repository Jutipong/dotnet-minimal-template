set host=localhost 
set dbname=Test-Test
set output_dir=Entities\Model
set context_dir=Entities\DbContext 
set context_name=AppContext

dotnet ef dbcontext scaffold "Server=%host%;Database=%dbname%; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --data-annotations --use-database-names --output-dir %output_dir% --context-dir %context_dir% --context "%context_name%" --no-onconfiguring --force
 