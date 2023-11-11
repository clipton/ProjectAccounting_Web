using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class OfficeHeadService : IOfficeHeadService
    {
        private readonly HttpClient httpClient ;
        public OfficeHeadService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblOfficeExpenceHead>> GetOfficeHead()
        {
            return await httpClient.GetFromJsonAsync<List<TblOfficeExpenceHead>>("api/OfficeHead/GetOfficeHead");
        }
        public async Task<TblUser> GetUserInfosById(int Id)
        {
            //return await httpClient.GetFromJsonAsync<TblUser>($"api/User/?Id" + Id);
            //return await httpClient.GetFromJsonAsync<TblUser>($"api/User/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>($"api/User/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>($"api/User/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>($"api/User/GetUserInfosById/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>("api/User/GetUserInfosById/?Id" + Id);
            var result = await httpClient.GetFromJsonAsync<TblUser>($"api/User/GetUserInfosById/{Id}");
            //var result =  await httpClient.GetFromJsonAsync<TblUser>($"api/User/?Id" + Id);
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
        
        public async Task<ResponseModel> AddNewUser(TblUser User)
        {
            var response = await httpClient.PostAsJsonAsync("api/User/AddNewUser", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateUser(TblUser User)
        {
            var response = await httpClient.PostAsJsonAsync("api/User/UpdateUser", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteUser(TblUser User)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/User/DeleteUser", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
    }
}
