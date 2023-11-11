using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblUserRole
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<TblUserPermissionMapping> TblUserPermissionMappings { get; set; } = new List<TblUserPermissionMapping>();
}
