using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class UserRoleService : IUserRoleService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public UserRoleService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblUserRole> GetUserRoles()
        { 
            var data = _projectAccountingContext.TblUserRoles.ToList();
            return data;
        }
        public ResponseModel AddNewUserRole(TblUserRole info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblUserRoles.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateUserRole(TblUserRole info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblUserRoles.Update(info);
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
        public ResponseModel DeleteUserRole(TblUserRole info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblUserRoles.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblUserRoles.Remove(data);
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
        public TblUserRole GetUserRoleInfosById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblUserRoles.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblUserRole();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
