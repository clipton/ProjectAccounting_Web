using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblExpenseDetail
{
    public int Id { get; set; }

    public int? ExpenseId { get; set; }

    public string? Particulars { get; set; }

    public decimal? Quantity { get; set; }

    public int? Unit { get; set; }

    public decimal? Rate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual TblExpense? Expense { get; set; }
}
