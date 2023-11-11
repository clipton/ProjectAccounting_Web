using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class Detail
{
    public int Id { get; set; }

    public int? MasterId { get; set; }

    public string? ChildName { get; set; }

    public int? Age { get; set; }

    public bool? IsMaleFemale { get; set; }

    public virtual Master? Master { get; set; }
}
