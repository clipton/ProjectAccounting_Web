using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient ;
        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblEmployee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<List<TblEmployee>>("api/Employee/Getemployees");
        }
        public async Task<ResponseModel> AddNewEmployee(TblEmployee employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Employee/AddNewEmployee", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> UpdateEmployee(TblEmployee employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Employee/UpdateEmployee", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteEmployee(int employeeId)
        {
            return await httpClient.GetFromJsonAsync<ResponseModel>("api/Employee/DeleteEmployee/?employeeId" + employeeId);
        }
    }
}
