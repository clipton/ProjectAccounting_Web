using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IMasterService
    {
        List<Master> GetMaster();
        Master GetMasterById(int Id);
        ResponseModel AddMaster(Master info);
        ResponseModel UpdateMaster(Master info);
        ResponseModel DeleteMaster(Master info);
    }
}
