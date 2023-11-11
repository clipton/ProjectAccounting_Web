using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class ClientService : IClientService
    {
        private readonly HttpClient httpClient ;
        public ClientService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblClient>> GetClient()
        {
            return await httpClient.GetFromJsonAsync<List<TblClient>>("api/Client/GetUsers");
        }
        public async Task<TblClient> GetClientInfoById(int Id)
        {
            
            var result = await httpClient.GetFromJsonAsync<TblClient>($"api/Client/GetClientInfoById/{Id}");
           
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
        
        public async Task<ResponseModel> AddClient(TblClient User)
        {
            var response = await httpClient.PostAsJsonAsync("api/Client/AddClient", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateClient(TblClient User)
        {
            var response = await httpClient.PostAsJsonAsync("api/Client/UpdateClient", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteClient(TblClient User)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/Client/DeleteClient", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }

       
    }
}
