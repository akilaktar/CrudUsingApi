using Microsoft.EntityFrameworkCore;

namespace CrudUsingApi.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) :base(options)   
        {

        }
        public DbSet<EmployeeDetails> employeeDetails { get; set; }
    }
}
