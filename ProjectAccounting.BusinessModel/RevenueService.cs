using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class RevenueService : IRevenueService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public RevenueService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblRevenue> GetRevenue()
        { 
            var data = _projectAccountingContext.TblRevenues.ToList();
            return data;
        }
        public ResponseModel AddRevenue(TblRevenue info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblRevenues.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateRevenue(TblRevenue info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblRevenues.Update(info);
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
        public ResponseModel DeleteRevenue(TblRevenue info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblRevenues.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblRevenues.Remove(data);
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

        public TblRevenue GetRevenueById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblRevenues.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblRevenue();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
