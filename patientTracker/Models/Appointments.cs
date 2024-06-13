namespace patientTracker.Models;

public class Appointments{

    public int AppointmentsId {get;set;}
    public  string ProcedureCode {get;set;}
    public int PatientId {get;set;}
    public int DoctorId {get;set;}
    public DateTime ScheduleTime {get;set;}


}