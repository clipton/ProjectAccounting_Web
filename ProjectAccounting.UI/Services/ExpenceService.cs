using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class ExpenceService : IExpenceService
    {
        private readonly HttpClient httpClient ;
        public ExpenceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblExpense>> GetExpense()
        {
            return await httpClient.GetFromJsonAsync<List<TblExpense>>("api/Expence/GetExpence");
        }
        public async Task<List<TblExpense>> GetCashExpence()
        {
            return await httpClient.GetFromJsonAsync<List<TblExpense>>("api/Expence/GetCashExpence");
        }
        public async Task<List<TblExpense>> GetSupplierExpence()
        {
            return await httpClient.GetFromJsonAsync<List<TblExpense>>("api/Expence/GetSupplierExpence");
        }
        public async Task<List<TblExpense>> GetOfficeExpence()
        {
            return await httpClient.GetFromJsonAsync<List<TblExpense>>("api/Expence/GetOfficeExpence");
        }
        public async Task<TblExpense> GetExpenceById(int Id)
        {
            var result = await httpClient.GetFromJsonAsync<TblExpense>($"api/Expence/GetExpenceById/{Id}");
           
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
            
        }
        public async Task<ResponseModel> AddExpence(TblExpense employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Expence/AddExpence", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> UpdateExpence(TblExpense employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Expence/UpdateExpence", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteExpence(TblExpense employee)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Expence/DeleteExpence", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
    }
}
