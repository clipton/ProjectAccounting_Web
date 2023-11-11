using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public EmployeeService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblEmployee> GetEmployInfos()
        { 
            var data = _projectAccountingContext.TblEmployees.ToList();
            return data;
        }
        public ResponseModel AddNewEmployee(TblEmployee info)
        { 
            ResponseModel response = new ResponseModel();
            //var data = _projectAccountingContext.EmployInfos.Where(x => x.FirstName == info.FirstName).FirstOrDefault();

            //IQueryable<EmployInfo> data = <EmployInfo>(from p in _projectAccountingContext.EmployInfos
            //                           where p.EmpId == info.EmpId
            //                               select p).FirstOrDefault();
            //if (data != null)
            //{
            //    data.FirstName = info.FirstName;
            //    data.LastName = info.LastName;
            //    data.PhoneNo = info.PhoneNo;

                _projectAccountingContext.TblEmployees.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
            //}
            //else {
            //    response.Status = false;
            //    response.Message = "Employye NOt Exits";

            //}
            return response;
        }
        public ResponseModel UpdateEmployee(TblEmployee info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblEmployees.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    //data.FirstName = info.FirstName;
                    //data.LastName = info.LastName;
                    //data.PhoneNo = info.PhoneNo;
                  
                    _projectAccountingContext.TblEmployees.Update(info);
                    _projectAccountingContext.SaveChanges();


                    response.Status = true;
                    response.Message = "Success";
                }
                else
                {
                    response.Status = false;
                    response.Message = "Does Not Exists";
                }
                
                return response;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public ResponseModel DeleteEmployee(int EmployeeId)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblEmployees.Where(x => x.Id == EmployeeId).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblEmployees.Remove(data);
                    _projectAccountingContext.SaveChanges();
                    response.Status = true;
                    response.Message = "Success";
                }
                else
                {
                    response.Status = false;
                    response.Message = "Does Not Exists";
                }

                return response;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
