using CrudUsingApi.Models;

namespace CrudUsingApi.Repository
{
    public interface IEmployeeRepository
    {
        public List<EmployeeDetails> GetEmployees();
        public bool InsertEmployees(EmployeeDetails model);

        public EmployeeDetails GetEmployeeEmployees(int? Id);

        public bool UpdateEmployee(EmployeeDetails model);

        public bool RemoveEmployee(int? Id);
    }
}
