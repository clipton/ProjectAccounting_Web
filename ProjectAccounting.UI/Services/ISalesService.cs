using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;

namespace ProjectAccounting.UI.Services
{
    public interface ISalesService
    {
        Task<List<TblSaleOrder>> GetSales();
        Task<List<VwSalesInfo>> GetvwSales();
        Task<ResponseModel> AddSale(TblSaleOrder employee);
        Task<ResponseModel> UpdateSale(TblSaleOrder employee);
        Task<ResponseModel> DeleteSale(TblSaleOrder employee);
        Task<TblSaleOrder> GetSalesById(int Id);
        Task<TblSaleOrder> GetSalesBySalesCode(string Code);


    }
}

