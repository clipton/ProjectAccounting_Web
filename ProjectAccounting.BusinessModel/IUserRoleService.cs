using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IUserRoleService
    {
        List<TblUserRole> GetUserRoles();
        TblUserRole GetUserRoleInfosById(int Id);
        ResponseModel AddNewUserRole(TblUserRole info);
        ResponseModel UpdateUserRole(TblUserRole info);
        ResponseModel DeleteUserRole(TblUserRole info);
    }
}
