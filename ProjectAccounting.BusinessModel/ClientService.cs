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
    public class ClientService : IClientService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public ClientService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblClient> GetClient()
        {
            var data = _projectAccountingContext.TblClients.ToList();
            return data;
        }
        public ResponseModel AddClient(TblClient info)
        {
            ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblClients.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateClient(TblClient info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblClients.Update(info);
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
        public ResponseModel DeleteClient(TblClient info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblClients.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblClients.Remove(data);
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

        public TblClient GetClientInfoById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblClients.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblClient();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

       
      

        
       

       
        

       
        
       
           
    }
}
