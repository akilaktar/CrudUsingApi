using CrudUsingApi.Models;

namespace CrudUsingApi.Repository
{
    public interface IEmployeeRepository
    {
        public List<EmployeeDetails> GetEmployees();
    }
}
