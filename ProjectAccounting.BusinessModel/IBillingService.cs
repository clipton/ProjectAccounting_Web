using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IBillingService
    {
        List<TblBilling> GetBillings();
        TblBilling GetBillingInfoById(int Id);
        ResponseModel AddBilling(TblBilling info);
        ResponseModel UpdateBilling(TblBilling info);
        ResponseModel DeleteBilling(TblBilling info);
    }
}
