using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IBankAccountOwnerService
    {
        Task<List<TblBankAccountOwner>> GetBankAccountOwner();
        Task<ResponseModel> AddNewUser(TblUser employee);
        Task<ResponseModel> UpdateUser(TblUser employee);
        Task<ResponseModel> DeleteUser(TblUser employee);
        Task<TblUser> GetUserInfosById(int Id);

    }
}

