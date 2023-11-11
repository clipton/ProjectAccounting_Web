using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IExpenceService
    {
        Task<List<TblExpense>> GetExpense();
        Task<List<TblExpense>> GetCashExpence();

        Task<List<TblExpense>> GetSupplierExpence();
        Task<List<TblExpense>> GetOfficeExpence();
        Task<ResponseModel> AddExpence(TblExpense employee);
        Task<ResponseModel> UpdateExpence(TblExpense employee);
        Task<ResponseModel> DeleteExpence(TblExpense employee);
        Task<TblExpense> GetExpenceById(int Id);

    }
}

