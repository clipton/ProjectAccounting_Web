using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProjectAccounting.UI.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly HttpClient httpClient ;
        public UserRoleService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblUserRole>> GetUserRoles()
        {
            return await httpClient.GetFromJsonAsync<List<TblUserRole>>("api/UserRole/GetUserRoles");
        }
        public async Task<TblUserRole> GetUserRoleInfosById(int Id)
        {
            //return await httpClient.GetFromJsonAsync<TblUser>($"api/User/?Id" + Id);
            //return await httpClient.GetFromJsonAsync<TblUser>($"api/User/{Id}");
            var result = await httpClient.GetFromJsonAsync<TblUserRole>($"api/UserRole/{Id}");
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
        
        public async Task<ResponseModel> AddNewUserRole(TblUserRole User)
        {
            var response = await httpClient.PostAsJsonAsync("api/UserRole/AddNewUserRole", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();

        }
        public async Task<ResponseModel> UpdateUserRole(TblUserRole User)
        {
            var response = await httpClient.PostAsJsonAsync("api/UserRole/UpdateUserRole", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
        public async Task<ResponseModel> DeleteUserRole(TblUserRole User)
        {
            // return await httpClient.GetFromJsonAsync<ResponseModel>("api/User/DeleteUser/?Id" + UserId);
            var response = await httpClient.PostAsJsonAsync("api/UserRole/DeleteUserRole", User);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }
    }
}
