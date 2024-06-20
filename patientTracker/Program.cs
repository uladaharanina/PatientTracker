using Microsoft.EntityFrameworkCore;
using patientTracker.Data;
using patientTracker.Services;
using patientTracker.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<PatientTrackerContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

//Add dependencyes

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IValidatinService, ValidateService>();
builder.Services.AddScoped<IHashingService, HashingService>();

//Add swagger
var app = builder.Build();
app.MapControllers();
  if (app.Environment.IsDevelopment())
  {
    app.UseSwagger();
    app.UseSwaggerUI();
  }

app.Run();
