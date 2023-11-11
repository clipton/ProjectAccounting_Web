using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblUserPermissionMapping
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int FormId { get; set; }

    public bool? View { get; set; }

    public bool? Save { get; set; }

    public bool? Edit { get; set; }

    public bool? Delete { get; set; }

    public virtual TblFormName Form { get; set; } = null!;

    public virtual TblUserRole Role { get; set; } = null!;
}
