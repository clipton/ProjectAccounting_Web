using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OfficeHeadController : ControllerBase
    {
        private readonly IOfficeHeadService UserService;
        public OfficeHeadController(IOfficeHeadService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetOfficeHead()
        {
            var data = UserService.GetOfficeHead();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblUser> GetUserInfosById(int Id)
        {
            var data = UserService.GetUserInfosById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUser")]
        public IActionResult DeleteUser(TblUser info)
        {
            var data = UserService.DeleteUser(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUser")]
        public IActionResult AddNewUser(TblUser info)
        {
            var data = UserService.AddNewUser(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateUser")]
        public IActionResult UpdateUser(TblUser info)
        {
            var data = UserService.UpdateUser(info);
            return Ok(data);
        }
    }
}
