var builder = WebApplication.CreateBuilder(args);
builder.AddSerilog();
builder.AddSwagger();
builder.AddAuthentication();
builder.AddAuthorization();
builder.AddDAtaBase();
builder.RegisterService();
// builder.RegisterRepository();
builder.Services.AddCors();
builder.Services.AddCarter();
builder.Services.Configure<AppSittingModel>(builder.Configuration.GetSection("AppSettings"));

var app = builder.Build();
// var environment = app.Environment;
// var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
app
    .UseExceptionHandling(app.Environment)
    .UseSwaggerEndpoints()
    .UseAppCors()
    .UseAuthentication()
    .UseAuthorization();

app.MapCarter();
app.Run();
