using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

var builder = WebApplication.CreateBuilder(args);
builder.AddConfig();
builder.AddSerilog();
builder.AddSwagger();
builder.AddAuthentication();
builder.AddAuthorization();
builder.AddDAtaBase();
builder.AddRegisterService();
// builder.AddRegisterRepository();
builder.Services.AddCors();
builder.Services.AddCarter();

var app = builder.Build();
app
    .UseExceptionHandling(app.Environment)
    .UseSwaggerEndpoints()
    .UseAppCors()
    .UseAuthentication()
    .UseAuthorization();

app.MapCarter();
app.Run();

// builder.Services.Configure<AppSittingModel>(builder.Configuration.GetSection("AppSettings"));