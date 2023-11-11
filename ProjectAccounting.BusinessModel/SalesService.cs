using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class SalesService : ISalesService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public SalesService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblSaleOrder> GetSales()
        { 
            var data = _projectAccountingContext.TblSaleOrders.OrderByDescending(x=>x.Id).ToList();
            return data;
        }
        public List<VwSalesInfo> GetvwSales()
        {
            var data = _projectAccountingContext.VwSalesInfos.OrderByDescending(x => x.Id).ToList();
            return data;
        }
        public ResponseModel AddSale(TblSaleOrder info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblSaleOrders.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateSale(TblSaleOrder info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblSaleOrders.Update(info);
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
        public ResponseModel DeleteSale(TblSaleOrder info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblSaleOrders.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblSaleOrders.Remove(data);
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

        public TblSaleOrder GetSalesById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblSaleOrders.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblSaleOrder();
                }

            }
            catch (Exception)
            {

                throw; 
            }
        }
        public TblSaleOrder GetSalesBySalesCode(string Scode)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblSaleOrders.SingleOrDefault(x => x.SalesOrderNo == Scode);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblSaleOrder();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
