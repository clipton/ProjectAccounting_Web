using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblClient
{
    public int Id { get; set; }

    public string? ClientCode { get; set; }

    public string? ClientName { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactPersonNumber { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<TblSaleOrder> TblSaleOrders { get; set; } = new List<TblSaleOrder>();
}
