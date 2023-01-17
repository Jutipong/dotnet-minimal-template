var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
var builder = WebApplication.CreateBuilder(args);

builder.AddConfig(environment!);
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
app.UseExceptionHandling(app.Environment)
    .UseSwaggerEndpoints()
    .UseAppCors()
    .UseAuthentication()
    .UseAuthorization();

app.MapCarter();
app.Run();