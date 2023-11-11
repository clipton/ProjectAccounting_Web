using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IPurchaseService
    {
        List<TblPurchaseOrder> GetPurchases();

        List<VwPurchaseinfo> GetVwPurchases();
        TblPurchaseOrder GetPurchasesById(int Id);
        TblPurchaseOrder GetPurchasesByCode(string Code);
        ResponseModel AddPurchases(TblPurchaseOrder info);
        ResponseModel UpdatePurchases(TblPurchaseOrder info);
        ResponseModel DeletePurchases(TblPurchaseOrder info);
    }
}
