using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccounting.BusinessModel
{
    public class RefundService : IRefundService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public RefundService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblRefundExpense> GetRefund()
        { 
            var data = _projectAccountingContext.TblRefundExpenses.ToList();
            return data;
        }
        public ResponseModel AddNewRefund(TblRefundExpense info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblRefundExpenses.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateRefund(TblRefundExpense info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblRefundExpenses.Update(info);
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
        public ResponseModel DeleteRefund(TblRefundExpense info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblRefundExpenses.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblRefundExpenses.Remove(data);
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

        public TblRefundExpense GetRefundById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblRefundExpenses.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblRefundExpense();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
