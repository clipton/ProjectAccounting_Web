using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public interface IEmployeeService
    {
        List<TblEmployee> GetEmployInfos();
        ResponseModel AddNewEmployee(TblEmployee info);
        ResponseModel UpdateEmployee(TblEmployee info);
        ResponseModel DeleteEmployee(int EmployeeId);
    }
}
