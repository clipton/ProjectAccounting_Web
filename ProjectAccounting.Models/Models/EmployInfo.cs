using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class EmployInfo
{
    public int EmpId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNo { get; set; }
}
