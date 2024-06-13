using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using patientTracker.Models;

namespace patientTracker.Data;

public class PatientTrackerContext : DbContext{

    public DbSet<Doctor> Doctors {get;set;}
    public DbSet<Patient> Patients {get;set;}


}