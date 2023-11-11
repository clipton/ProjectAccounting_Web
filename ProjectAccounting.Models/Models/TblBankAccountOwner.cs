using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblBankAccountOwner
{
    public int Id { get; set; }

    public string? AccountName { get; set; }

    public string? Owner { get; set; }

    public virtual ICollection<TblExpense> TblExpenses { get; set; } = new List<TblExpense>();
}
