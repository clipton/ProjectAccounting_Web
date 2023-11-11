using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IClientService
    {
        List<TblClient> GetClient();
        TblClient GetClientInfoById(int Id);
        ResponseModel AddClient(TblClient info);
        ResponseModel UpdateClient(TblClient info);
        ResponseModel DeleteClient(TblClient info);
    }
}
