using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService) {
            this.employeeService = _employeeService;
        }
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees() 
        { 
            var data = employeeService.GetEmployInfos();   
            return Ok(data);

        }
        [HttpGet]
        [Route("DeleteEmployee")]
        public IActionResult DeleteEmployee(int employeeId)
        {
            var data = employeeService.DeleteEmployee(employeeId);
            return Ok(data);

        }
        [HttpPost]
        [Route("AddNewEmployee")]
        public IActionResult AddNewEmployee(TblEmployee info)
        {
            var data = employeeService.AddNewEmployee(info);
            return Ok(data);
        }
        [HttpPost]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(TblEmployee info)
        {
            var data = employeeService.UpdateEmployee(info);
            return Ok(data);
        }


    }
}
