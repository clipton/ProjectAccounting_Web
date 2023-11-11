using System;
using System.Collections.Generic;

namespace ProjectAccounting.Models.Models;

public partial class TblEmployee
{
    public int Id { get; set; }

    public string? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? Designation { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? Createdate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<TblExpense> TblExpenses { get; set; } = new List<TblExpense>();

    public virtual ICollection<TblSaleOrder> TblSaleOrders { get; set; } = new List<TblSaleOrder>();
}
