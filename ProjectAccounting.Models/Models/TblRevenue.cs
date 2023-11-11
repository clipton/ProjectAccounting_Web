using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblRevenue
{
    public int Id { get; set; }

    public int? SalesOrderId { get; set; }

    public string? SalesOrderNo { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public decimal? BillAmount { get; set; }

    public string? VoucherNo { get; set; }

    public string? PayOrderNo { get; set; }

    public DateTime? PayOrderDate { get; set; }

    public decimal? NetBill { get; set; }

    public int? AdvancePhase { get; set; }

    public bool? IsfinalPayment { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public decimal? AdvanceAmount { get; set; }

    public decimal? VatTaxAmount { get; set; }

    public DateTime? BankReceiveDate { get; set; }

    public int? BankAccountId { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChequeDate { get; set; }

    public decimal? Aitamunt { get; set; }

    public decimal? Amount { get; set; }

    public bool? Approved { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }
}
