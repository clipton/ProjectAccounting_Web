using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectAccounting.Models.Models;

public partial class TblSaleOrder
{
    public int Id { get; set; }

    [Required]
    public string? SalesOrderNo { get; set; }

    public int? CleintId { get; set; }

    public int? OwnersId { get; set; }

    public int? PmId { get; set; }

    public string? PlaceofWork { get; set; }

    public string? TypeOfWork { get; set; }


    [Required]
    public string? AppWorkValue { get; set; }

    public DateTime? Startdate { get; set; }
   
    public string? ProjectName { get; set; }

    public DateTime? ClosingDate { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public bool IsProjectClose { get; set; }

    public DateTime? ProjectCloseDate { get; set; }

    public virtual TblClient? Cleint { get; set; }

    public virtual TblCompany? Company { get; set; }

    public virtual TblOwner? Owners { get; set; }

    public virtual TblEmployee? Pm { get; set; }

    public virtual ICollection<TblPurchaseOrder> TblPurchaseOrders { get; set; } = new List<TblPurchaseOrder>();

    public virtual TblUser? UpdateUser { get; set; }
}
