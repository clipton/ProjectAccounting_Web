using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class MasterService : IMasterService
    {
        private readonly HttpClient httpClient ;
        public MasterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Master>> GetMaster() { 
            return await httpClient.GetFromJsonAsync<List<Master>>("api/Master/GetMaster");
        }
        public async Task<Master> GetMasterById(int Id)
        {
            var result = await httpClient.GetFromJsonAsync<Master>($"api/Master/GetMasterById/{Id}");
           
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
            
        }
        public async Task<ResponseModel> AddMaster(Master employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Master/AddMaster", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateMaster(Master employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Expence/UpdateMaster", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteMaster(Master employee)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Master/DeleteMaster", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
    }
}
