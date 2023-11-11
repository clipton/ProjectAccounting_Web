using Microsoft.EntityFrameworkCore;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class MasterService : IMasterService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public MasterService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<Master> GetMaster()
        { 
            var data = _projectAccountingContext.Masters.Include("Details").ToList();
            return data;
        }
        public ResponseModel AddMaster(Master info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.Masters.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateMaster(Master info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.Masters.Update(info);
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
        public ResponseModel DeleteMaster(Master info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.Masters.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.Masters.Remove(data);
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

        public Master GetMasterById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.Masters.Include("Details").SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new Master();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
