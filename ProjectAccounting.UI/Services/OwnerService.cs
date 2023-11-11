using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly HttpClient httpClient ;
        public OwnerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblOwner>> GetOwners()
        {
            return await httpClient.GetFromJsonAsync<List<TblOwner>>("api/Owner/GetOwners");
        }
        public async Task<TblOwner> GetOwnerInfosById(int Id)  
        {
           
            var result = await httpClient.GetFromJsonAsync<TblOwner>($"api/Owner/GetOwnerInfosById/{Id}");
           
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("NOt Found");
            }
            //return await httpClient.GetFromJsonAsync<TblUser>("api/User/GetUserInfosById/{Id}");
        }
        
        public async Task<ResponseModel> AddOwner(TblOwner Owner)
        {
            var response = await httpClient.PostAsJsonAsync("api/Owner/AddOwner", Owner);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateOwner(TblOwner Owner)
        {
            var response = await httpClient.PostAsJsonAsync("api/Owner/UpdateOwner", Owner);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteOwner(TblOwner Owner)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Owner/DeleteOwner", Owner);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
    }
}
