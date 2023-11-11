using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IOfficeHeadService
    {
        Task<List<TblOfficeExpenceHead>> GetOfficeHead();
        Task<ResponseModel> AddNewUser(TblUser employee);
        Task<ResponseModel> UpdateUser(TblUser employee);
        Task<ResponseModel> DeleteUser(TblUser employee);
        Task<TblUser> GetUserInfosById(int Id);

    }
}

