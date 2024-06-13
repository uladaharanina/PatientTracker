using System.ComponentModel.DataAnnotations;

namespace patientTracker.Models;

public class Procedur{

    [Key]
    public  string ProcedureCode  {get;set;}

    [Required(ErrorMessage = "Procedure's name is required")]
    public string ProcedureName  {get;set;}
    public string ProcedureDescription  {get;set;}


}