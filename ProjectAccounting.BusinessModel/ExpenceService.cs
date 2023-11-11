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
    public class ExpenceService : IExpenceService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public ExpenceService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        //public List<TblExpense> GetExpence()
        //{
        //    //var data = _projectAccountingContext.TblExpenses.Include("TblExpenseDetails").ToList();
        //    // var data = _projectAccountingContext.TblExpenses.ToList();
        //    var data = _projectAccountingContext.TblExpenses.FromSqlRaw("SELECT Id,SalesOrderId,SalesOrderNo,PurchaseOrderId,PurchaseOrderNo,VoucherNumber,PersonId,SupplierBillNo,SupplierBillDate,Amount,PurchaseDescription,ReceiveDate,IsDueAdvance,IsCashCheque,ChequeNo,ChequeDate,PaymentPhase,BankAccountID,Approved,CreateUserId,Createdate,UpdateUserId,UpdateDate,CompanyId,AdvancePurchaseNo,IsFinalPayment,ChequeCleared,TypeOfExpense,OfficeExpenseId,IsOnlineBanking,OnlineBankingNumber FROM tblExpense where TypeOfExpense =2 order by Id Desc").ToList();
        //    return data;
        //}
        public List<TblExpense> GetExpence()
        {
            //var data = _projectAccountingContext.TblExpenses.Include("TblExpenseDetails").ToList();
            // var data = _projectAccountingContext.TblExpenses.ToList();
            var data = _projectAccountingContext.TblExpenses.FromSqlRaw("SELECT Id,SalesOrderId,SalesOrderNo,PurchaseOrderId,PurchaseOrderNo,VoucherNumber,PersonId,SupplierBillNo,SupplierBillDate,Amount,PurchaseDescription,ReceiveDate,IsDueAdvance,IsCashCheque,ChequeNo,ChequeDate,PaymentPhase,BankAccountID,Approved,CreateUserId,Createdate,UpdateUserId,UpdateDate,CompanyId,AdvancePurchaseNo,IsFinalPayment,ChequeCleared,TypeOfExpense,OfficeExpenseId,IsOnlineBanking,OnlineBankingNumber FROM tblExpense order by Id Desc").ToList();
            return data;
        }
        public List<TblExpense> GetCashExpence()
        {
            //var data = _projectAccountingContext.TblExpenses.Include("TblExpenseDetails").ToList();
            // var data = _projectAccountingContext.TblExpenses.ToList();
            var data = _projectAccountingContext.TblExpenses.FromSqlRaw("SELECT Id,SalesOrderId,SalesOrderNo,PurchaseOrderId,PurchaseOrderNo,VoucherNumber,PersonId,SupplierBillNo,SupplierBillDate,Amount,PurchaseDescription,ReceiveDate,IsDueAdvance,IsCashCheque,ChequeNo,ChequeDate,PaymentPhase,BankAccountID,Approved,CreateUserId,Createdate,UpdateUserId,UpdateDate,CompanyId,AdvancePurchaseNo,IsFinalPayment,ChequeCleared,TypeOfExpense,OfficeExpenseId,IsOnlineBanking,OnlineBankingNumber FROM tblExpense where TypeOfExpense =2 order by Id Desc").ToList();
            return data;
        }
        public List<TblExpense> GetSupplierExpence()
        {
            //var data = _projectAccountingContext.TblExpenses.Include("TblExpenseDetails").ToList();
            // var data = _projectAccountingContext.TblExpenses.ToList();
            var data = _projectAccountingContext.TblExpenses.FromSqlRaw("SELECT Id,SalesOrderId,SalesOrderNo,PurchaseOrderId,PurchaseOrderNo,VoucherNumber,PersonId,SupplierBillNo,SupplierBillDate,Amount,PurchaseDescription,ReceiveDate,IsDueAdvance,IsCashCheque,ChequeNo,ChequeDate,PaymentPhase,BankAccountID,Approved,CreateUserId,Createdate,UpdateUserId,UpdateDate,CompanyId,AdvancePurchaseNo,IsFinalPayment,ChequeCleared,TypeOfExpense,OfficeExpenseId,IsOnlineBanking,OnlineBankingNumber FROM tblExpense where TypeOfExpense = 1 order by Id Desc").ToList();
            return data;
        }
        public List<TblExpense> GetOfficeExpence()
        {
            //var data = _projectAccountingContext.TblExpenses.Include("TblExpenseDetails").ToList();
            // var data = _projectAccountingContext.TblExpenses.ToList();
            var data = _projectAccountingContext.TblExpenses.FromSqlRaw("SELECT Id,SalesOrderId,SalesOrderNo,PurchaseOrderId,PurchaseOrderNo,VoucherNumber,PersonId,SupplierBillNo,SupplierBillDate,Amount,PurchaseDescription,ReceiveDate,IsDueAdvance,IsCashCheque,ChequeNo,ChequeDate,PaymentPhase,BankAccountID,Approved,CreateUserId,Createdate,UpdateUserId,UpdateDate,CompanyId,AdvancePurchaseNo,IsFinalPayment,ChequeCleared,TypeOfExpense,OfficeExpenseId,IsOnlineBanking,OnlineBankingNumber FROM tblExpense where TypeOfExpense =3 order by Id Desc").ToList();
            return data;
        }
        public ResponseModel AddExpence(TblExpense expense)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                //expense.TypeOfExpense = 1;
                //expense.IsCashCheque = true;
                //expense.IsDueAdvance = true;
                //expense.IsFinalPayment = false;
                //expense.IsOnlineBanking = false;
                //expense.ChequeCleared = false;
                //expense.Approved = false;
                //expense.AdvancePurchaseNo = null;
                //expense.OfficeExpenseId = 0;

                //expense.PaymentPhase = 1;
                //expense.PersonId = 17;
                //expense.PurchaseOrderId = 2612;
                //expense.SalesOrderId = 552;
                //expense.BankAccountId = 15;

                //expense.VoucherNumber = "585858";
                //expense.SupplierBillNo = "585858";
                _projectAccountingContext.TblExpenses.Add(expense);
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
        public ResponseModel UpdateExpence(TblExpense info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblExpenses.Update(info);
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
        public ResponseModel DeleteExpence(TblExpense info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblExpenses.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblExpenses.Remove(data);
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

        public TblExpense GetExpenceById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblExpenses.Include("TblExpenseDetails").SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblExpense();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
