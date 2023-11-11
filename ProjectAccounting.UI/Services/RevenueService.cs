using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class RevenueService : IRevenueService
    {
        private readonly HttpClient httpClient ;
        public RevenueService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblRevenue>> GetRevenue()
        {
            return await httpClient.GetFromJsonAsync<List<TblRevenue>>("api/Revenue/GetRevenue");
        }
        public async Task<TblRevenue> GetRevenueById(int Id)
        {
            var result = await httpClient.GetFromJsonAsync<TblRevenue>($"api/Revenue/GetRevenueById/{Id}");
           
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
        }
        
        public async Task<ResponseModel> AddRevenue(TblRevenue revenue)
        {
            var response = await httpClient.PostAsJsonAsync("api/Revenue/AddRevenue", revenue);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateRevenue(TblRevenue employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Revenue/UpdateRevenue", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteRevenue(TblRevenue employee)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Revenue/DeleteRevenue", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
      
    }
}
