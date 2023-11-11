using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class RefundService : IRefundService
    {
        private readonly HttpClient httpClient ;
        public RefundService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblRefundExpense>> GetRefund()
        {
            return await httpClient.GetFromJsonAsync<List<TblRefundExpense>>("api/Refund/GetRefund");
        }
        public async Task<TblRefundExpense> GetRefundById(int Id)
        {
            
            var result = await httpClient.GetFromJsonAsync<TblRefundExpense>($"api/Refund/GetRefundInfosById/{Id}");
            
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
           
        }
        
        public async Task<ResponseModel> AddNewRefund(TblRefundExpense RefundExpense)
        {
            var response = await httpClient.PostAsJsonAsync("api/Refund/AddNewRefund", RefundExpense);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateRefund(TblRefundExpense RefundExpense)
        {
            var response = await httpClient.PostAsJsonAsync("api/Refund/UpdateRefund", RefundExpense);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteRefund(TblRefundExpense RefundExpense)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Refund/DeleteRefund", RefundExpense);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
    }
}
