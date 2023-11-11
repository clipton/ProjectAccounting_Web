using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblExpense
{
    public int Id { get; set; }

    public int? SalesOrderId { get; set; }

    public string? SalesOrderNo { get; set; }

    public int? PurchaseOrderId { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public string? VoucherNumber { get; set; }

    public int? PersonId { get; set; }

    public string? SupplierBillNo { get; set; }

    public DateTime? SupplierBillDate { get; set; }

    public decimal? Amount { get; set; }

    public string? PurchaseDescription { get; set; }

    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// 0= Due= False, 1= Advance= True
    /// </summary>
    public bool IsDueAdvance { get; set; }

    /// <summary>
    /// 0= Cash, 1= Cheque
    /// </summary>
    public bool IsCashCheque { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChequeDate { get; set; }

    public int? PaymentPhase { get; set; }

    public int? BankAccountId { get; set; }

    public bool Approved { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public string? AdvancePurchaseNo { get; set; }

    public bool IsFinalPayment { get; set; }

    public bool ChequeCleared { get; set; }

    public int? TypeOfExpense { get; set; }

    public int? OfficeExpenseId { get; set; }

    public bool IsOnlineBanking { get; set; }

    public int? OnlineBankingNumber { get; set; }

    public virtual TblBankAccountOwner? BankAccount { get; set; }

    public virtual TblEmployee? Person { get; set; }

    public virtual ICollection<TblExpenseDetail> TblExpenseDetails { get; set; } = new List<TblExpenseDetail>();
}
