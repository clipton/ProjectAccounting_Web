using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class SupplierService : ISupplierService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public SupplierService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblSupplier> GetSupplier()
        { 
            var data = _projectAccountingContext.TblSuppliers.OrderByDescending(x=>x.Id).ToList();
            return data;
        }
        public ResponseModel AddSupplier(TblSupplier info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblSuppliers.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateSupplier(TblSupplier info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblSuppliers.Update(info);
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
        public ResponseModel DeleteSupplier(TblSupplier info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblSuppliers.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblSuppliers.Remove(data);
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

        public TblSupplier GetSupplierById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblSuppliers.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblSupplier();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
