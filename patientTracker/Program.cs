using Microsoft.EntityFrameworkCore;
using patientTracker.Data;
using patientTracker.Services;
using patientTracker.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<PatientTrackerContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

builder.Services.AddControllers();

//Add dependencyes

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();


//Add swagger

app.MapControllers();

app.Run();
