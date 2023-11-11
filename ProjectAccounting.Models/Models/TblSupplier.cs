using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblSupplier
{
    public int Id { get; set; }

    public string? SupplerCode { get; set; }

    public string? SupplierName { get; set; }

    public string? OwnerName { get; set; }

    public string? TypeOfWork { get; set; }

    public string? AccountName { get; set; }

    public string? AccountNo { get; set; }

    public string? Fax { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? Telephone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<TblPurchaseOrder> TblPurchaseOrders { get; set; } = new List<TblPurchaseOrder>();
}
