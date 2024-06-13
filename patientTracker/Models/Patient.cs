using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patientTracker.Models;

public class Patient{

    [Key]
    public string PatientId {get;set;}

    [Required(ErrorMessage = "Patient's name is required")]
    public  string FullName {get;set;}
    public int Age {get;set;}

    public string Address {get;set;}
    public int Height {get;set;}
    public int Weight {get;set;}

    [Required(ErrorMessage = "Patient's diagnosis is required")]
    public string Diagnosis {get;set;}
    [Required(ErrorMessage = "Patient's prmary care doctor's is required")]

    public int PrimaryDoctor {get;set;}

    [ForeignKey("UserId")]
    public User User {get;set;}

}