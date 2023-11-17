using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace FamilyPromiseApp.Models
{
    public class Resource
    {
        public int ID { get; set; }
        public string Category { get; set; }
    }
}