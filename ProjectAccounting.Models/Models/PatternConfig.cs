using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class PatternConfig
{
    public int AutoId { get; set; }

    public string ConfigType { get; set; } = null!;

    public bool? IsAutoGenCode { get; set; }

    public string? Prefix1 { get; set; }

    public string? Prefix2 { get; set; }

    public string? Prefix3 { get; set; }

    public string? Suffix1 { get; set; }

    public string? Suffix2 { get; set; }

    public string? Delimiter { get; set; }

    public int DigitNumber { get; set; }

    public int CurrentNumber { get; set; }
}
