using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class VwSalesInfo
{
    public string? SalesOrderNo { get; set; }

    public string? ClientName { get; set; }

    public DateTime? Startdate { get; set; }

    public string? PlaceofWork { get; set; }

    public string? TypeOfWork { get; set; }

    public bool IsProjectClose { get; set; }

    public int Id { get; set; }

    public string? AppWorkValue { get; set; }

    public string? ProjectName { get; set; }

    public string? EmployeeName { get; set; }

    public string? Owners { get; set; }

    public string? ClientCode { get; set; }

    public DateTime? ProjectCloseDate { get; set; }

    public int? CleintId { get; set; }

    public int? OwnersId { get; set; }

    public int? PmId { get; set; }

}
