using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IOwnerService
    {
        List<TblOwner> GetOwners();
        TblOwner GetOwnerInfosById(int Id);
        ResponseModel AddOwner(TblOwner info);
        ResponseModel UpdateOwner(TblOwner info);
        ResponseModel DeleteOwner(TblOwner info);
    }
}
