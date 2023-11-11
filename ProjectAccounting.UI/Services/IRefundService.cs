using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IRefundService
    {
        Task<List<TblRefundExpense>> GetRefund();
        Task<ResponseModel> AddNewRefund(TblRefundExpense employee);
        Task<ResponseModel> UpdateRefund(TblRefundExpense employee);
        Task<ResponseModel> DeleteRefund(TblRefundExpense employee);
        Task<TblRefundExpense> GetRefundById(int Id);
       

    }
}

