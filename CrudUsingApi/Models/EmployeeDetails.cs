using System.ComponentModel.DataAnnotations;

namespace CrudUsingApi.Models
{
    public class EmployeeDetails
    {
        [Key] //imp
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
}
