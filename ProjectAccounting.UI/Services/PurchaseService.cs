using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly HttpClient httpClient ;
        public PurchaseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblPurchaseOrder>> GetPurchases()
        {
            return await httpClient.GetFromJsonAsync<List<TblPurchaseOrder>>("api/Purchase/GetPurchases");
        }
       
        
        public async Task<List<VwPurchaseinfo>> GetvwPurchases()
        {
            return await httpClient.GetFromJsonAsync<List<VwPurchaseinfo>>("api/Purchase/GetvwPurchases");
        }
        public async Task<TblPurchaseOrder> GetPurchasesById(int Id)
        {
            var result = await httpClient.GetFromJsonAsync<TblPurchaseOrder>($"api/Purchase/GetPurchasesById/{Id}");
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
        }
        public async Task<TblPurchaseOrder> GetpurchaseByCode(string Code)
        {
            var result = await httpClient.GetFromJsonAsync<TblPurchaseOrder>($"api/Purchase/GetPurchasesByCode/{Code}");
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
        }
        public async Task<ResponseModel> AddPurchases(TblPurchaseOrder employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Purchase/AddPurchases", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdatePurchases(TblPurchaseOrder employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Purchase/UpdatePurchases", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeletePurchases(TblPurchaseOrder employee)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Purchase/DeletePurchases", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }

        

       

      
       
      
    }
}
