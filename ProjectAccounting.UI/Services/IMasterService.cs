using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IMasterService
    {
        Task<List<Master>> GetMaster();
        Task<ResponseModel> AddMaster(Master employee);
        Task<ResponseModel> UpdateMaster(Master employee);
        Task<ResponseModel> DeleteMaster(Master employee);
        Task<Master> GetMasterById(int Id);

    }
}

