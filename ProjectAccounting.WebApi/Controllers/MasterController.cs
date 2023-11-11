using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService UserService;
        public MasterController(IMasterService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetExpence()
        {
            var data = UserService.GetMaster();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<Master> GetMasterById(int Id)
        {
            var data = UserService.GetMasterById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUser")]
        public IActionResult DeleteMaster(Master info)
        {
            var data = UserService.DeleteMaster(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUser")]
        public IActionResult AddMaster(Master info)
        {
            var data = UserService.AddMaster(info);
            return Ok(data);
        }
        [HttpPost]
        // [Route("UpdateUser")]
        public IActionResult UpdateMaster(Master info)
        {
            var data = UserService.UpdateMaster(info);
            return Ok(data);
        }
    }
}
