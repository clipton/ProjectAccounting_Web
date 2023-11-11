using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IRefundService
    {
        List<TblRefundExpense> GetRefund();
        
        TblRefundExpense GetRefundById(int Id);
        ResponseModel AddNewRefund(TblRefundExpense info);
        ResponseModel UpdateRefund(TblRefundExpense info);
        ResponseModel DeleteRefund(TblRefundExpense info);
    }
}
