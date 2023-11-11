using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class BillingService : IBillingService
    {
        private readonly HttpClient httpClient ;
        public BillingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblBilling>> GetBillings()
        {
            return await httpClient.GetFromJsonAsync<List<TblBilling>>("api/Billing/GetBilling");
        }
        public async Task<TblBilling> GetBillingInfoById(int Id)
        {
            
            var result = await httpClient.GetFromJsonAsync<TblBilling>($"api/Billing/GetBillingInfoById/{Id}");
            
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
            
        }
        
        public async Task<ResponseModel> AddBilling(TblBilling User)
        {
            var response = await httpClient.PostAsJsonAsync("api/Billing/AddBilling", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateBilling(TblBilling User)
        {
            var response = await httpClient.PostAsJsonAsync("api/Billing/UpdateBilling", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteBilling(TblBilling User)
        {
            var response = await httpClient.PostAsJsonAsync("api/Billing/DeleteBilling", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }

       
    }
}
