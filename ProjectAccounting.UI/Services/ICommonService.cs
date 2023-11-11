using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface ICommonService
    {
        Task<List<TblUser>> GetUsers();
        Task<ResponseModel> AddNewUser(TblUser employee);
        Task<ResponseModel> UpdateUser(TblUser employee);
        Task<ResponseModel> DeleteUser(TblUser employee);
        Task<TblUser> GetUserInfosById(int Id);

        Task<sp_GetPatternConfig> GetCodeByCode(string Id);

    }
}

