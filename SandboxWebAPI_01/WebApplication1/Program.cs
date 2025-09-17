using Microsoft.EntityFrameworkCore;
using WebAppSandbox01.Models;
using MediatR;
using WebAppSandbox01.Services;
using WebAppSandbox01.Repos;

var MyAllowSpecificOrigins = "_MyAllowSubdomainPolicy";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options => {
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("*")
            .SetIsOriginAllowedToAllowWildcardSubdomains()
            .AllowCredentials();
        }
    );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("ToDoList"));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddSingleton<WeatherStationRepo>();
builder.Services.AddSingleton<WeatherStationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
