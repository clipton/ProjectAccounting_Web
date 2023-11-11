using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblBilling
{
    public int Id { get; set; }

    public string? VoucharNumber { get; set; }

    public int? SalesOrderId { get; set; }

    public string? SalesOrderNo { get; set; }

    public int? ClientId { get; set; }

    public int? AccountOwnersId { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public decimal? BillAmount { get; set; }

    public int? BillPhase { get; set; }

    public bool IsFinalBill { get; set; }

    public DateTime? RevisedBillDate { get; set; }

    public decimal? RevisedBillAmount { get; set; }

    public DateTime? BillReciveDate { get; set; }

    public string? Remarks { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }
}
