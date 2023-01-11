using Microsoft.OpenApi.Models;
using todo = Api.Features.Todo;

var builder = WebApplication.CreateBuilder(args);
builder.AddSwagger();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCarter();//AddCarter

//========== Register appsetting.json ==========//
builder.Services.Configure<AppSittingModel>(builder.Configuration.GetSection("AppSettings"));
//========== Register Connection Db ==========//
builder.Services.AddDbContext<DbContexts>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DbContexts")));

//========== Add Service and Repositories ==========//
builder.Services.AddScoped<todo.Service.IService, todo.Service.Service>();
builder.Services.AddScoped<todo.Repositories.IRepositories, todo.Repositories.Repositories>();

// var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


var app = builder.Build();
app
.UseExceptionHandling(app.Environment)
.UseSwaggerEndpoints(string.Empty);
// .UseAppCors();
// .UseAuthentication()
// .UseAuthorization();

app.MapCarter();//MapCarter
app.Run();