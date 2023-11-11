using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IClientService
    {
        Task<List<TblClient>> GetClient();
        Task<ResponseModel> AddClient(TblClient employee);
        Task<ResponseModel> UpdateClient(TblClient employee);
        Task<ResponseModel> DeleteClient(TblClient employee);
        Task<TblClient> GetClientInfoById(int Id);


    }
}

