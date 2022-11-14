using CrudUsingApi.Models;
using CrudUsingApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudUsingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HomeApiController : ControllerBase
    {
        public IEmployeeRepository _employeeRepository;
        public HomeApiController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet("api/GetEmployees")]
        public  IActionResult GetEmployees()
        {
            var result =  _employeeRepository.GetEmployees().ToList();
            return Ok(result);
        }
        [HttpPost("api/InsertEmployees")]
        public IActionResult InsertEmployees(EmployeeDetails employee)
        {
            var result = _employeeRepository.InsertEmployees(employee);
            return Ok(result);
        }
        [HttpGet("api/GetEmployeeById/{Id}")]
        public IActionResult GetEmployeeById(int? Id)
        {
            var result = _employeeRepository.GetEmployeeEmployees(Id);
            return Ok(result);
        }
        [HttpPut("api/UpdateEmployee/{Id}")]
        public IActionResult UpdateEmployee(EmployeeDetails model,int? Id)
        {
            if(model.Id!=Id)
            {
                return BadRequest();
            }
            else
            {
                var res = _employeeRepository.UpdateEmployee(model);
                return Ok(res);
            }

        }

        [HttpDelete("api/DeleteEmployee/{Id}")]
        public IActionResult DeleteEmployee(int? Id)
        {
            var result = _employeeRepository.RemoveEmployee(Id);
            return Ok(result);
        }
    }
}
