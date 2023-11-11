using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class VwExpenseinfo
{
    public string? SalesOrderNo { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public string? VoucherNumber { get; set; }

    public int? PersonId { get; set; }

    public int Id { get; set; }

    public int? SalesOrderId { get; set; }
}
