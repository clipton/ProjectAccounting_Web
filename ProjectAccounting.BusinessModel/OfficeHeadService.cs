using Microsoft.EntityFrameworkCore;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class OfficeHeadService : IOfficeHeadService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public OfficeHeadService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblOfficeExpenceHead> GetOfficeHead()
        { 
            var data = _projectAccountingContext.TblOfficeExpenceHeads.ToList();
            return data;
        }
        public ResponseModel AddNewUser(TblUser info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblUsers.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateUser(TblUser info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblUsers.Update(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
                //var data = _projectAccountingContext.TblUsers.Where(x => x.Id == info.Id).FirstOrDefault();
                //if (data != null)
                //{
                //    data.UserName = info.UserName;
                //    data.UserCode = info.UserCode;
                //    data.Password = info.Password;
                //    data.UserRoleId = info.UserRoleId;
                //    _projectAccountingContext.TblUsers.Update(data);
                //    _projectAccountingContext.SaveChanges();
                //    response.Status = true;
                //    response.Message = "Success";
                //}
                //else
                //{
                //    response.Status = false;
                //    response.Message = "Does Not Exists";
                //}
                
                return response;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public ResponseModel DeleteUser(TblUser info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblUsers.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblUsers.Remove(data);
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

        public TblUser GetUserInfosById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblUsers.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblUser();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
