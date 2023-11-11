using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService UserService;
        public SalesController(ISalesService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetSalesOrder()
        {
            var data = UserService.GetSales();
            return Ok(data);
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetvwSalesOrder()
        {
            var data = UserService.GetvwSales();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblSaleOrder> GetSalesOrderById(int Id)
        {
            var data = UserService.GetSalesById(Id);
            return data;
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Code}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblSaleOrder> GetSalesBySalesCode(string Code)
        {
            var data = UserService.GetSalesBySalesCode(Code);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUser")]
        public IActionResult DeletealesOrder(TblSaleOrder info)
        {
            var data = UserService.DeleteSale(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddSale")]
        public IActionResult AddSale(TblSaleOrder info)
        {
            var data = UserService.AddSale(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateSale")]
        public IActionResult UpdateSale(TblSaleOrder info)
        {
            var data = UserService.UpdateSale(info);
            return Ok(data);
        }
    }
}
