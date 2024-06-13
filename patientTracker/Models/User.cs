using System.ComponentModel.DataAnnotations;

namespace patientTracker.Models;

public class User{

[Key]
public int userId {get;set;}
public string username {get;set;}
public string password {get;set;}
public int role_id {get;set;}  
public DateTime dateCreated {get;set;}

// Navigation property
public ICollection<Patient> Patients { get; set; }
public ICollection<Doctor> Doctors { get; set; }
 
}