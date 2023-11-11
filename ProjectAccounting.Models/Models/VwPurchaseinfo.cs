using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class VwPurchaseinfo
{
    public string? SalesOrderNo { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public int? SalesOrderId { get; set; }

    public decimal? Amount { get; set; }

    public string? ClientName { get; set; }

    public string? PlaceofWork { get; set; }

    public string? TypeOfWork { get; set; }

    public int Id { get; set; }

    public string? AppWorkValue { get; set; }

    public DateTime? Startdate { get; set; }

    public string? ProjectName { get; set; }

    public string? ClientCode { get; set; }

    public string? ItemDescrition { get; set; }

    public DateTime? PurchaseOrderDate { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? SupplerCode { get; set; }

    public string? SupplierName { get; set; }
}
