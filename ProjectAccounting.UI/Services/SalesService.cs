using Azure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class SalesService : ISalesService
    {
        private readonly HttpClient httpClient ;
        public SalesService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblSaleOrder>> GetSales()
        {
            return await httpClient.GetFromJsonAsync<List<TblSaleOrder>>("api/Sales/GetSalesOrder");
             
        }
        public async Task<List<VwSalesInfo>> GetvwSales()
        {
            return await httpClient.GetFromJsonAsync<List<VwSalesInfo>>("api/Sales/GetvwSalesOrder");

        }
        public async Task<TblSaleOrder> GetSalesById(int Id)
        {
           
            var result = await httpClient.GetFromJsonAsync<TblSaleOrder>($"api/Sales/GetSalesOrderById/{Id}");
            
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
            
        }
        public async Task<TblSaleOrder> GetSalesBySalesCode(string Code)
        {
            var result = await httpClient.GetFromJsonAsync<TblSaleOrder>($"api/Sales/GetSalesBySalesCode/{Code}");

            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }

        }
        public async Task<ResponseModel> AddSale(TblSaleOrder employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Sales/AddSale", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateSale(TblSaleOrder employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Sales/UpdateSale", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteSale(TblSaleOrder employee)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Sales/DeletealesOrder", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        
    }
}
