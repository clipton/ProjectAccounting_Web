using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface IPurchaseService
    {
        Task<List<TblPurchaseOrder>> GetPurchases();

        Task<List<VwPurchaseinfo>> GetvwPurchases();
        Task<ResponseModel> AddPurchases(TblPurchaseOrder employee);
        Task<ResponseModel> UpdatePurchases(TblPurchaseOrder employee);
        Task<ResponseModel> DeletePurchases(TblPurchaseOrder employee);
        Task<TblPurchaseOrder> GetPurchasesById(int Id);
        Task<TblPurchaseOrder> GetpurchaseByCode(string Code);
        
    }
}

