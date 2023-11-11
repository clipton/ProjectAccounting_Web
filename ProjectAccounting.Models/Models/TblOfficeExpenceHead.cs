using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblOfficeExpenceHead
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ExpenceType { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }
}
