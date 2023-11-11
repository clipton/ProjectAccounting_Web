using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IOwnerService
    {
        Task<List<TblOwner>> GetOwners();
        Task<ResponseModel> AddOwner(TblOwner employee);
        Task<ResponseModel> UpdateOwner(TblOwner employee);
        Task<ResponseModel> DeleteOwner(TblOwner employee);
        Task<TblOwner> GetOwnerInfosById(int Id);
        

    }
}

