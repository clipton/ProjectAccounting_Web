using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IExpenceService
    {
        List<TblExpense> GetExpence();

        List<TblExpense> GetCashExpence();
        List<TblExpense> GetSupplierExpence();

        List<TblExpense> GetOfficeExpence();

        
        TblExpense GetExpenceById(int Id);
        ResponseModel AddExpence(TblExpense info);
        ResponseModel UpdateExpence(TblExpense info);
        ResponseModel DeleteExpence(TblExpense info);
    }
}
