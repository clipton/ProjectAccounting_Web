using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IUserService
    {
        Task<List<TblUser>> GetUsers();
        Task<ResponseModel> AddNewUser(TblUser User);
        Task<ResponseModel> UpdateUser(TblUser User);
        Task<ResponseModel> DeleteUser(TblUser User);
        Task<TblUser> GetUserInfosById(int Id);
        //Task<ResponseModel> GetUserCodePass(TblUser User);
        Task<TblUser> GetUserCodePass(string UserCode, string password);


    }
}

