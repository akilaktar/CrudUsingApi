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
        public bool InsertEmployees(EmployeeDetails model)
        {
            _employeeContext.employeeDetails.Add(model);
            var result = _employeeContext.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public EmployeeDetails GetEmployeeEmployees(int? Id)
        {
            //_employeeContext.employeeDetails.Find(Id);
            var employeeDetails = _employeeContext.employeeDetails.Find(Id);
            return employeeDetails;
        }

        public bool UpdateEmployee(EmployeeDetails model)
        {
            var emp = _employeeContext.employeeDetails.Where(x => x.Id == model.Id).FirstOrDefault();
            if (emp != null)
            {
                emp.Name = model.Name;
                emp.Salary = model.Salary;
                var result = _employeeContext.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;

        }
        public bool RemoveEmployee(int? Id)
        {
            var employeeDetails = _employeeContext.employeeDetails.Find(Id);
            var emprem = _employeeContext.Remove(employeeDetails);
            var result = _employeeContext.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
