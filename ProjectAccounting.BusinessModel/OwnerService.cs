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
    public class OwnerService : IOwnerService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public OwnerService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblOwner> GetOwners()
        {
            var data = _projectAccountingContext.TblOwners.ToList();
            return data;
        }
        public ResponseModel AddOwner(TblOwner info)
        {
            ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblOwners.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateOwner(TblOwner info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblOwners.Update(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
                
                
                return response;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public ResponseModel DeleteOwner(TblOwner info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblOwners.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblOwners.Remove(data);
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

        public TblOwner GetOwnerInfosById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblOwners.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblOwner();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
