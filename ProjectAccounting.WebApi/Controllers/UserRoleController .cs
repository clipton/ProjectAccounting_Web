using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService UserService;
        public UserRoleController(IUserRoleService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUserRoles")]
        public IActionResult GetUserRoles()
        {
            var data = UserService.GetUserRoles();
            return Ok(data);
        }

        //[HttpGet("{id}")]
        //[Route("GetUserInfosById")]
        //[HttpGet("GetUserInfosById/{Id?}")]
        //[HttpGet("GetUserInfosById/{id:int}")]
        //[HttpGet("GetUserInfosById/{id:int}")]
        //[HttpGet("{id}")]
        //[Route("{Id}", Name = "GetUserInfosById")]
        //[HttpGet("{Id}")]
        //[Route("GetUserRoleInfosById")]
        //[HttpGet]
        //[Route("api/[controller]/[action]/{Id}")]

        [HttpGet("{id}")]
        //[Route("GetUserRoleInfosById")]
        public ActionResult<TblUserRole> GetUserRoleInfosById(int Id)
        {
            var data = UserService.GetUserRoleInfosById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUserRole")]
        public IActionResult DeleteUserRole(TblUserRole info)
        {
            var data = UserService.DeleteUserRole(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUserRole")]
        public IActionResult AddNewUserRole(TblUserRole info)
        {
            var data = UserService.AddNewUserRole(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateUserRole")]
        public IActionResult UpdateUserRole(TblUserRole info)
        {
            var data = UserService.UpdateUserRole(info);
            return Ok(data);
        }
    }
}
