using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IBankAccountOwnerService
    {
        List<TblBankAccountOwner> GetBankAccountOwner();
        TblUser GetUserInfosById(int Id);
        ResponseModel AddNewUser(TblUser info);
        ResponseModel UpdateUser(TblUser info);
        ResponseModel DeleteUser(TblUser info);
    }
}
