var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCarter();//AddCarter

//========== Register appsetting.json ==========//
builder.Services.Configure<AppSittingModel>(builder.Configuration.GetSection("AppSettings"));
//========== Register Connection Db ==========//
builder.Services.AddDbContext<DBContexts>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DbContexts")));

//========== Add Service and Repositories ==========//
builder.Services.AddScoped<Features.Todo.Service.IService, Features.Todo.Service.Service>();
builder.Services.AddScoped<Features.Todo.Repositories.IRepositories, Features.Todo.Repositories.Repositories>();


var app = builder.Build();
app.MapCarter();//MapCarter

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //set start swagger page
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();