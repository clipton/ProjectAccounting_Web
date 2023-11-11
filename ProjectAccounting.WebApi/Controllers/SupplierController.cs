using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService UserService;
        public SupplierController(ISupplierService _employeeService) {
            this.UserService = _employeeService;
        }
        [HttpGet]
        //[Route("GetUsers")]
        public IActionResult GetSupplier()
        {
            var data = UserService.GetSupplier();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("[action]/{Id}")]
        [HttpGet("{Id}")]
        //[Route("GetUserInfosById")]
        public ActionResult<TblSupplier> GetSupplierById(int Id)
        {
            var data = UserService.GetSupplierById(Id);
            return data;
        }
        [HttpPost]
        //[Route("DeleteUser")]
        public IActionResult DeleteSupplier(TblSupplier info)
        {
            var data = UserService.DeleteSupplier(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("AddNewUser")]
        public IActionResult AddSupplier(TblSupplier info)
        {
            var data = UserService.AddSupplier(info);
            return Ok(data);
        }
        [HttpPost]
        //[Route("UpdateUser")]
        public IActionResult UpdateSupplier(TblSupplier info)
        {
            var data = UserService.UpdateSupplier(info);
            return Ok(data);
        }
    }
}
