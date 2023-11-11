using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class PurchaseService : IPurchaseService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public PurchaseService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblPurchaseOrder> GetPurchases()
        { 
            var data = _projectAccountingContext.TblPurchaseOrders.OrderByDescending(x=>x.Id).ToList();
            return data;
        }
        public List<VwPurchaseinfo> GetVwPurchases()
        {
            var data = _projectAccountingContext.VwPurchaseinfos.OrderByDescending(x => x.Id).ToList();
            return data;
        }
        public ResponseModel AddPurchases(TblPurchaseOrder info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblPurchaseOrders.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdatePurchases(TblPurchaseOrder info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblPurchaseOrders.Update(info);
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
        public ResponseModel DeletePurchases(TblPurchaseOrder info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblPurchaseOrders.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblPurchaseOrders.Remove(data);
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
        public TblPurchaseOrder GetPurchasesById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblPurchaseOrders.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblPurchaseOrder();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public TblPurchaseOrder GetPurchasesByCode(string Code)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblPurchaseOrders.SingleOrDefault(x => x.PurchaseOrderNo == Code);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblPurchaseOrder();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
