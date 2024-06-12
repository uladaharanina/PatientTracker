using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllers();

app.MapControllers();
//app.MapGet("/", () => "Hello World!");

app.Run();
