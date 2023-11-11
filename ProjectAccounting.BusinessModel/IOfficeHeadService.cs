using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IOfficeHeadService
    {
        List<TblOfficeExpenceHead> GetOfficeHead();
        TblUser GetUserInfosById(int Id);
        ResponseModel AddNewUser(TblUser info);
        ResponseModel UpdateUser(TblUser info);
        ResponseModel DeleteUser(TblUser info);
    }
}
