using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class VwSalesOrder
{
    public int Id { get; set; }

    public string? SalesOrderNo { get; set; }

    public int ClientId { get; set; }

    public int Pmid { get; set; }

    public int OwnerId { get; set; }

    public string? PlaceofWork { get; set; }

    public string? TypeOfWork { get; set; }

    public string? AppWorkValue { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? ClosingDate { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ClientName { get; set; }

    public string? EmployeeName { get; set; }

    public string? Owners { get; set; }
}
