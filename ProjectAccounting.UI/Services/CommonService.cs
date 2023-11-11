﻿using Azure;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace ProjectAccounting.UI.Services
{
    public class CommonService : ICommonService
    {
        private readonly HttpClient httpClient ;
        public CommonService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<TblUser>> GetUsers()
        {
            return await httpClient.GetFromJsonAsync<List<TblUser>>("api/User/GetUsers");
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
        public async Task<sp_GetPatternConfig> GetCodeByCode(string Code)
        {
            //return await httpClient.GetFromJsonAsync<TblUser>($"api/User/?Id" + Id);
            //return await httpClient.GetFromJsonAsync<TblUser>($"api/User/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>($"api/User/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>($"api/User/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>($"api/User/GetUserInfosById/{Id}");
            //var result = await httpClient.GetFromJsonAsync<TblUser>("api/User/GetUserInfosById/?Id" + Id);
            var result = await httpClient.GetFromJsonAsync<sp_GetPatternConfig>($"api/Common/GetCodeByCode/{Code}");

            //result = JsonSerializer.Deserialize<List<sp_GetPatternConfig>>(result);
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
