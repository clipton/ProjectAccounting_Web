using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface ISupplierService
    {
        Task<List<TblSupplier>> GetSupplier();
        Task<ResponseModel> AddSupplier(TblSupplier employee);
        Task<ResponseModel> UpdateSupplier(TblSupplier employee);
        Task<ResponseModel> DeleteSupplier(TblSupplier employee);
        Task<TblSupplier> GetSupplierById(int Id);
    }
}

