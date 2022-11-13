using CrudUsingApi.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CrudUsingApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeContext _employeeContext;    
        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext; 
        }

        public List<EmployeeDetails> GetEmployees()
        {
            return _employeeContext.employeeDetails.ToList();
        }
    }
}
