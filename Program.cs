using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectef;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
builder.Services.AddDbContext<AssignmentContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", async ([FromServices] AssignmentContext dbContext) =>
{
	dbContext.Database.EnsureCreated();
	return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
