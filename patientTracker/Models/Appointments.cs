using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patientTracker.Models;

public class Appointments{

    [Key]
    public int AppointmentsId {get;set;}

    [Required]
    public DateTime ScheduleTime {get;set;}

    [Required(ErrorMessage = "Doctor's ID is required")]
    public string DoctorId {get;set;}

    [Required(ErrorMessage = "Patient's ID is required")]
    public string PatientId {get;set;}
    [Required(ErrorMessage = "Procedure's code is required")]
    public string ProcedureCode {get;set;}


    //Relationships
    [ForeignKey("ProcedureCode")]
    public Procedure Procedure {get;set;}

    [ForeignKey("PatientId")]
    public Patient Patients {get;set;}

    [ForeignKey("DoctorId")]
    public Doctor Doctor {get;set;}


}