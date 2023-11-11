using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CommonController : ControllerBase
    {
        private readonly ICommonService UserService;
        public CommonController(ICommonService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetUsers()
        {
            var data = UserService.GetUsers();
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
       
        [HttpGet("{Code}")]
        //[Route("GetUserInfosById")]
        public ActionResult<sp_GetPatternConfig> GetCodeByCode(string Code)
        {
            sp_GetPatternConfig data = UserService.GetCodeByCode(Code);
            return Ok(data);
        }


        [HttpGet("{Code}")]
        public ActionResult<sp_GetPatternConfig> GetCodeById(string Code)
        {
            sp_GetPatternConfig data = (sp_GetPatternConfig)UserService.GetCodeById(Code);
            return Ok(data);
        }
        
    }
}
