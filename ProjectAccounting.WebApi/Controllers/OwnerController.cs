using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService UserService;
        public OwnerController(IOwnerService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUserRoles")]
        public IActionResult GetOwners()
        {
            var data = UserService.GetOwners();
            return Ok(data);
        }
        [HttpGet("{id}")]
        //[Route("GetUserRoleInfosById")]
        public ActionResult<TblOwner> GetOwnerInfosById(int Id)
        {
            var data = UserService.GetOwnerInfosById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUserRole")]
        public IActionResult DeleteOwner(TblOwner info)
        {
            var data = UserService.DeleteOwner(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUserRole")]
        public IActionResult AddOwner(TblOwner info)
        {
            var data = UserService.AddOwner(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateUserRole")]
        public IActionResult UpdateOwner(TblOwner info)
        {
            var data = UserService.UpdateOwner(info);
            return Ok(data);
        }
    }
}
