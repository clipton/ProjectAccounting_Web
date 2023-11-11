using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface ISalesService
    {
        List<TblSaleOrder> GetSales();

        List<VwSalesInfo> GetvwSales();
        TblSaleOrder GetSalesById(int Id);

        TblSaleOrder GetSalesBySalesCode(string Scode);
        ResponseModel AddSale(TblSaleOrder info);
        ResponseModel UpdateSale(TblSaleOrder info);
        ResponseModel DeleteSale(TblSaleOrder info);
    }
}
