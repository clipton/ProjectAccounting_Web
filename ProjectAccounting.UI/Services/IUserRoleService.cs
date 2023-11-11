using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IUserRoleService
    {
        Task<List<TblUserRole>> GetUserRoles();
        Task<ResponseModel> AddNewUserRole(TblUserRole employee);
        Task<ResponseModel> UpdateUserRole(TblUserRole employee);
        Task<ResponseModel> DeleteUserRole(TblUserRole employee);
        Task<TblUserRole> GetUserRoleInfosById(int Id);
    }
}

