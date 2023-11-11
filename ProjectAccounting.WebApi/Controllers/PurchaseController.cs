using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService UserService;
        public PurchaseController(IPurchaseService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetPurchases()
        {
            var data = UserService.GetPurchases();
            return Ok(data);
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetvwPurchases()
        {
            var data = UserService.GetVwPurchases();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblPurchaseOrder> GetPurchasesById(int Id)
        {
            var data = UserService.GetPurchasesById(Id);
            return data;
        }
        [HttpGet("{Code}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblPurchaseOrder> GetPurchasesByCode(string Code)
        {
            var data = UserService.GetPurchasesByCode(Code);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUser")]
        public IActionResult DeletePurchases(TblPurchaseOrder info)
        {
            var data = UserService.DeletePurchases(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUser")]
        public IActionResult AddPurchases(TblPurchaseOrder info)
        {
            var data = UserService.AddPurchases(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateUser")]
        public IActionResult UpdatePurchases(TblPurchaseOrder info)
        {
            var data = UserService.UpdatePurchases(info);
            return Ok(data);
        }
    }
}
