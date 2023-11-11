using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService UserService;
        public ClientController(IClientService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetUsers()
        {
            var data = UserService.GetClient();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblClient> GetClientInfoById(int Id)
        {
            var data = UserService.GetClientInfoById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUser")]
        public IActionResult DeleteClient(TblClient info)
        {
            var data = UserService.DeleteClient(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUser")]
        public IActionResult AddClient(TblClient info)
        {
            var data = UserService.AddClient(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateUser")]
        public IActionResult UpdateClient(TblClient info)
        {
            var data = UserService.UpdateClient(info);
            return Ok(data);
        }
    }
}
