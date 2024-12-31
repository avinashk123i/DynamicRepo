using Clean.Controllers;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Service;
using Services.Abstractions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adding an Inmemory database handler for faster results and less work since it is a demo project.
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseInMemoryDatabase("GenericOnion"));

// Registering both the repository manager as well as the service manager
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();

// Adding this here so we can add the controllers which are defined inside another class library project #Most Important step.
var refrensingAssembly = typeof(WeatherForecastController).Assembly;
builder.Services.AddControllers().AddApplicationPart(refrensingAssembly);

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
