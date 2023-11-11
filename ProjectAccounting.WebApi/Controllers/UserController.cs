using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;
        public UserController(IUserService _employeeService) {
            this.UserService = _employeeService;
        }

        //[Route("GetUsers")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            var data = UserService.GetUsers();
            return Ok(data);
        }
        
        //[Route("GetUserCodepass")]
        //[HttpPost]
        //[HttpGet("{UserCode}/{Password}")]
        [HttpGet("{UserCode},{Password}")]
        public ActionResult<TblUser> GetUserCodepass(string UserCode, string password)
        {
            var data = UserService.GetUserInfosByUserPass(UserCode, password);
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
