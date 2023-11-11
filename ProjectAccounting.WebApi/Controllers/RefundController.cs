using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RefundController : ControllerBase
    {
        private readonly IRefundService UserService;
        public RefundController(IRefundService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetRefund")]
        public IActionResult GetRefund()
        {
            var data = UserService.GetRefund();
            return Ok(data);
        }
        //[Route("/[controller]/[action]/{id}")]
        //[Route("GetRefundInfosById")]
        //[HttpGet]
        //[Route("api/[controller]/[action]/{Id}")]
        [HttpGet("{id}")]
        //[Route("GetRefundInfosById")]
        public ActionResult<TblRefundExpense> GetRefundInfosById(int Id)
        {
            var data = UserService.GetRefundById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteRefund")]
        public IActionResult DeleteRefund(TblRefundExpense info)
        {
            var data = UserService.DeleteRefund(info);
            return Ok(data);
        }
        [HttpPost]
        ///[Route("AddNewRefund")]
        public IActionResult AddNewRefund(TblRefundExpense info)
        {
            var data = UserService.AddNewRefund(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateRefund")]
        public IActionResult UpdateRefund(TblRefundExpense info)
        {
            var data = UserService.UpdateRefund(info);
            return Ok(data);
        }
    }
}
