using Microsoft.EntityFrameworkCore;
using patientTracker.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<PatientTrackerContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

builder.Services.AddControllers();

//Add swagger

app.MapControllers();

app.Run();
