using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IBillingService
    {
        Task<List<TblBilling>> GetBillings();
        Task<ResponseModel> AddBilling(TblBilling info);
        Task<ResponseModel> UpdateBilling(TblBilling info);
        Task<ResponseModel> DeleteBilling(TblBilling info);
        Task<TblBilling> GetBillingInfoById(int Id);

      
    }
}

