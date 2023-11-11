using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ExpenceController : ControllerBase
    {
        private readonly IExpenceService UserService;
        public ExpenceController(IExpenceService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetExpence()
        {
            var data = UserService.GetExpence();
            return Ok(data);
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetCashExpence()
        {
            var data = UserService.GetCashExpence();
            return Ok(data);
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetSupplierExpence()
        {
            var data = UserService.GetSupplierExpence();
            return Ok(data);
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetOfficeExpence()
        {
            var data = UserService.GetOfficeExpence();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblExpense> GetExpenceById(int Id)
        {
            var data = UserService.GetExpenceById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUser")]
        public IActionResult DeleteExpence(TblExpense info)
        {
            var data = UserService.DeleteExpence(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUser")]
        public IActionResult AddExpence(TblExpense info)
        {
            var data = UserService.AddExpence(info);
            return Ok(data);
        }
        [HttpPost]
        // [Route("UpdateUser")]
        public IActionResult UpdateExpence(TblExpense info)
        {
            var data = UserService.UpdateExpence(info);
            return Ok(data);
        }
    }
}
