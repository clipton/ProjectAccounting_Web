using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblPurchaseOrder
{
    public int Id { get; set; }

    public int? SalesOrderId { get; set; }

    public string? SalesOrderNo { get; set; }

    public int? SupplierId { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public DateTime? PurchaseOrderDate { get; set; }

    public string? ItemDescrition { get; set; }

    public decimal? Amount { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TblSaleOrder? SalesOrder { get; set; }

    public virtual TblSupplier? Supplier { get; set; }
}
