using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblRefundExpense
{
    public int Id { get; set; }

    public int? SalesOrderId { get; set; }

    public string? SalesOrderNo { get; set; }

    public int? PurchaseNoId { get; set; }

    public string? PurchaseNo { get; set; }

    public string? VoucherNumber { get; set; }

    public int? RefExpenseId { get; set; }

    public int? PersonId { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? RefundAmount { get; set; }

    public decimal? BalanceAmount { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public bool? IsCashCheque { get; set; }

    public bool? Submit { get; set; }

    public bool? Approved { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }
}
