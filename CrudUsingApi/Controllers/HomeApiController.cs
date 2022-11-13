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
    }
}
