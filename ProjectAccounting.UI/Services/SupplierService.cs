using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly HttpClient httpClient ;
        public SupplierService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblSupplier>> GetSupplier()
        {
            return await httpClient.GetFromJsonAsync<List<TblSupplier>>("api/Supplier/GetSupplier");
            
        }
        public async Task<TblSupplier> GetSupplierById(int Id)
        {
            var result = await httpClient.GetFromJsonAsync<TblSupplier>($"api/Supplier/GetSupplierById/{Id}");
          
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
        }
        
        public async Task<ResponseModel> AddSupplier(TblSupplier User)
        {
            var response = await httpClient.PostAsJsonAsync("api/Supplier/AddSupplier", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateSupplier(TblSupplier User)
        {
            var response = await httpClient.PostAsJsonAsync("api/Supplier/UpdateSupplier", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteSupplier(TblSupplier User)
        {
            
            var response = await httpClient.PostAsJsonAsync("api/Supplier/DeleteSupplier", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }

       

    }
}
