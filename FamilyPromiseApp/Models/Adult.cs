
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyPromiseApp.Data;
namespace FamilyPromiseApp.Models;
public class Adult {
    public int ID { get; set; }
    public int CaseID { get; set; }
    public int PersonID { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public int Age { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }
    public string CellPhone { get; set; }
    public string WorkPhone { get; set; }
    public string Email { get; set; }

    public int AdultNumber { get; set; }
    


}