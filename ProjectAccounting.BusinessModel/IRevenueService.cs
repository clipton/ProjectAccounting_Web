using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IRevenueService
    {
        List<TblRevenue> GetRevenue();
        TblRevenue GetRevenueById(int Id);
        ResponseModel AddRevenue(TblRevenue info);
        ResponseModel UpdateRevenue(TblRevenue info);
        ResponseModel DeleteRevenue(TblRevenue info);
    }
}
