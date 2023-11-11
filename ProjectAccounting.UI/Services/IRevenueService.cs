using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IRevenueService
    {
        Task<List<TblRevenue>> GetRevenue();
        Task<ResponseModel> AddRevenue(TblRevenue employee);
        Task<ResponseModel> UpdateRevenue(TblRevenue employee);
        Task<ResponseModel> DeleteRevenue(TblRevenue employee);
        Task<TblRevenue> GetRevenueById(int Id);

    }
}

