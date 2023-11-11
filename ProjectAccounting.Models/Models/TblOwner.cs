using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblOwner
{
    public int Id { get; set; }

    public string? Owners { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<TblSaleOrder> TblSaleOrders { get; set; } = new List<TblSaleOrder>();
}
