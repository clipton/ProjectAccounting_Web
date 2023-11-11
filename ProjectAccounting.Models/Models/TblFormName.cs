using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblFormName
{
    public int Id { get; set; }

    public string? FormName { get; set; }

    public virtual ICollection<TblUserPermissionMapping> TblUserPermissionMappings { get; set; } = new List<TblUserPermissionMapping>();
}
