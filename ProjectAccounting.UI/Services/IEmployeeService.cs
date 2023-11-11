using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IEmployeeService
    {
        Task<List<TblEmployee>> GetEmployees();
        Task<ResponseModel> AddNewEmployee(TblEmployee employee);
        Task<ResponseModel> UpdateEmployee(TblEmployee employee);
        Task<ResponseModel> DeleteEmployee(int employeeId);
        
    }
}
