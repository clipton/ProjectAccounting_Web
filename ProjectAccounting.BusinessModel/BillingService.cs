using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class BillingService : IBillingService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public BillingService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblBilling> GetBillings()
        { 
            var data = _projectAccountingContext.TblBillings.ToList();
            return data;
        }
        public ResponseModel AddBilling(TblBilling info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblBillings.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateBilling(TblBilling info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblBillings.Update(info);
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
        public ResponseModel DeleteBilling(TblBilling info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblBillings.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblBillings.Remove(data);
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

        public TblBilling GetBillingInfoById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblBillings.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblBilling();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
