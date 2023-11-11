using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BillingController : ControllerBase
    {
        private readonly IBillingService UserService;
        public BillingController(IBillingService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUserRoles")]
        public IActionResult GetBilling()
        {
            var data = UserService.GetBillings();
            return Ok(data);
        }
        [HttpGet("{id}")]
        //[Route("GetUserRoleInfosById")]
        public ActionResult<TblBilling> GetBillingInfoById(int Id)
        {
            var data = UserService.GetBillingInfoById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUserRole")]
        public IActionResult DeleteBilling(TblBilling info)
        {
            var data = UserService.DeleteBilling(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUserRole")]
        public IActionResult AddBilling(TblBilling info)
        {
            var data = UserService.AddBilling(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateUserRole")]
        public IActionResult UpdateBilling(TblBilling info)
        {
            var data = UserService.UpdateBilling(info);
            return Ok(data);
        }
    }
}
