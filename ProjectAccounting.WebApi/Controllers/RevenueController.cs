using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RevenueController : ControllerBase
    {
        private readonly IRevenueService UserService;
        public RevenueController(IRevenueService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetRevenue()
        {
            var data = UserService.GetRevenue();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblRevenue> GetRevenueById(int Id)
        {
            var data = UserService.GetRevenueById(Id);
            return data;
        }
        [HttpPost]
       // [Route("DeleteUser")]
        public IActionResult DeleteRevenue(TblRevenue info)
        {
            var data = UserService.DeleteRevenue(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUser")]
        public IActionResult AddRevenue(TblRevenue info)
        {
            var data = UserService.AddRevenue(info);
            return Ok(data);
        }
        [HttpPost]
       // [Route("UpdateRevenue")]
        public IActionResult UpdateRevenue(TblRevenue info)
        {
            var data = UserService.UpdateRevenue(info);
            return Ok(data);
        }
    }
}
