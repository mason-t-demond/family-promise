
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyPromiseApp.Data;
namespace FamilyPromiseApp.Models;
public class Child {
    public int ID { get; set; }
    [ForeignKey("Case")]
    public int CaseID { get; set; }
    [ForeignKey("Person")]

    public int PersonID { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public int Age { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }


}