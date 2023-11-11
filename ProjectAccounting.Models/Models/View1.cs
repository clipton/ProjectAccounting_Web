using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class View1
{
    public int Id { get; set; }

    public int ExpenseId { get; set; }

    public string? Particulars { get; set; }

    public int? SalesOrderId { get; set; }
}
