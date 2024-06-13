using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using patientTracker.Models;

namespace patientTracker.Data;

public class PatientTrackerContext : DbContext{

    public DbSet<User> Users {get;set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        //Configure sequence of how userId should be generated (created a sequence in the db)
        modelBuilder.Entity<User>().Property(entity => entity.UserId)
                                    .ValueGeneratedOnAdd()
                                    .HasDefaultValueSql("NEXT VALUE FOR userIdIncrement");
            

        // Add initial roles 

        modelBuilder.Entity<Role>().HasData(
            new Role{RoleId = 1, RoleName = "Tech", AccessLevel = 3},
            new Role{RoleId = 2, RoleName = "Doctor", AccessLevel = 2},
            new Role{RoleId = 3, RoleName = "Patient", AccessLevel = 1}
        );

        modelBuilder.Entity<User>().HasData(
            new User{UserId = 1000, 
                        Username = "administrator", 
                        Password = "administrator24!", 
                        RoleId = 3
            }

        );
    }
    public DbSet<Doctor> Doctors {get;set;}
    public DbSet<Patient> Patients {get;set;}
    public DbSet<Role> Roles {get;set;}
    public DbSet<Appointments> Appointments {get;set;}


}