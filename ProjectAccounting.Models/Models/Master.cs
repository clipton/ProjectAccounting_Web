using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class Master
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<Detail> Details { get; set; } = new List<Detail>();
}
