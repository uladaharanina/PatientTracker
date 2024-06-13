using Microsoft.EntityFrameworkCore;
using patientTracker.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PatientTrackerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConectionString")));

var app = builder.Build();

builder.Services.AddControllers();

app.MapControllers();
//app.MapGet("/", () => "Hello World!");

app.Run();
