namespace patientTracker.Models;

public class Doctor{
    public int userID;
    public string fullName;
    public string specialization;
    public string education;

    public string phoneNumber;
    public DateTime hireDate;

    public List<Patient> patients;

}

