using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patientTracker.Models;

public class Doctor{

    [Key]
    public int DoctorId {get;set;}
    [Required]
    public int UserId {get;set;}

    public string fullName{get;set;}
    public string specialization{get;set;}
    public string education{get;set;}

    public string phoneNumber{get;set;}

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime hireDate {get;set;} = DateTime.UtcNow;


    //Relationships
    [ForeignKey("UserId")]
    public User User {get;set;}
    public List<Patient> Patients {get;set;}

}

