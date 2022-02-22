using Api.Features.Todo;
using Carter;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();//AddCarter
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Service
//*****User AddSingleton for static data test
//*****Default Use AddScoped
builder.Services.AddScoped<ITodoService, TodoService>();

var app = builder.Build();
app.MapCarter(); //MapCarter

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