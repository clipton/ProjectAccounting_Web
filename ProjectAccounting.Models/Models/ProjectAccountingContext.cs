using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectAccounting.Models.Models;

public partial class ProjectAccountingContext : DbContext
{
    public ProjectAccountingContext()
    {
    }

    public ProjectAccountingContext(DbContextOptions<ProjectAccountingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Detail> Details { get; set; }

    public virtual DbSet<EmployInfo> EmployInfos { get; set; }

    public virtual DbSet<Master> Masters { get; set; }

    public virtual DbSet<PatternConfig> PatternConfigs { get; set; }

    public virtual DbSet<TblBankAccountOwner> TblBankAccountOwners { get; set; }

    public virtual DbSet<TblBilling> TblBillings { get; set; }

    public virtual DbSet<TblClient> TblClients { get; set; }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblExpense> TblExpenses { get; set; }

    public virtual DbSet<TblExpenseDetail> TblExpenseDetails { get; set; }

    public virtual DbSet<TblFormName> TblFormNames { get; set; }

    public virtual DbSet<TblOfficeExpenceHead> TblOfficeExpenceHeads { get; set; }

    public virtual DbSet<TblOwner> TblOwners { get; set; }

    public virtual DbSet<TblPurchaseOrder> TblPurchaseOrders { get; set; }

    public virtual DbSet<TblRefundExpense> TblRefundExpenses { get; set; }

    public virtual DbSet<TblRevenue> TblRevenues { get; set; }

    public virtual DbSet<TblSaleOrder> TblSaleOrders { get; set; }

    public virtual DbSet<TblSupplier> TblSuppliers { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserPermissionMapping> TblUserPermissionMappings { get; set; }

    public virtual DbSet<TblUserRole> TblUserRoles { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<VwExpenseinfo> VwExpenseinfos { get; set; }

    public virtual DbSet<VwPurchaseinfo> VwPurchaseinfos { get; set; }

    public virtual DbSet<VwSalesInfo> VwSalesInfos { get; set; }

    public virtual DbSet<VwSalesOrder> VwSalesOrders { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=HRVENTURE;Database=ProjectAccounting;User ID=sa;Password=Sa@1234;Trusted_Connection=True;\nTrustServerCertificate=True;");


    public virtual DbSet<sp_GetPatternConfig> sp_GetPatternConfig { get; set; }
   
    public virtual IEnumerable<sp_GetPatternConfig> sp_GetPatternConfigs(String code)
    {
        return this.sp_GetPatternConfig.FromSqlInterpolated($"[dbo].[sp_GetPatternConfig] {code}").AsEnumerable();

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Detail>(entity =>
        {
            entity.Property(e => e.ChildName)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.Master).WithMany(p => p.Details)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK_Details_Master");
        });

        modelBuilder.Entity<EmployInfo>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EmployInfo");

            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
        });

        modelBuilder.Entity<Master>(entity =>
        {
            entity.ToTable("Master");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<PatternConfig>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("PatternConfig");

            entity.Property(e => e.ConfigType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Delimiter)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DigitNumber).HasDefaultValueSql("((3))");
            entity.Property(e => e.IsAutoGenCode)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Prefix1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Prefix2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Prefix3)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Suffix1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Suffix2)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBankAccountOwner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BankAccountOwner");

            entity.ToTable("tblBankAccountOwner");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.Owner).HasMaxLength(50);
        });

        modelBuilder.Entity<TblBilling>(entity =>
        {
            entity.ToTable("tblBilling");

            entity.Property(e => e.BillAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BillDate).HasColumnType("date");
            entity.Property(e => e.BillNo).HasMaxLength(30);
            entity.Property(e => e.BillReciveDate).HasColumnType("date");
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.RevisedBillAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RevisedBillDate).HasColumnType("date");
            entity.Property(e => e.SalesOrderNo).HasMaxLength(30);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
            entity.Property(e => e.VoucharNumber).HasMaxLength(30);
        });

        modelBuilder.Entity<TblClient>(entity =>
        {
            entity.ToTable("tblClient");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.ClientCode).HasMaxLength(50);
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .HasColumnName("clientName");
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.ContactPersonNumber)
                .HasMaxLength(50)
                .HasColumnName("ContactPErsonNumber");
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.ToTable("tblCompany");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.CompanyCode).HasMaxLength(10);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.ToTable("tblEmployee", tb => tb.HasTrigger("performanceTest"));

            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployeeCode).HasMaxLength(10);
            entity.Property(e => e.EmployeeName).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(30);
            entity.Property(e => e.Mobile).HasMaxLength(30);
            entity.Property(e => e.Telephone).HasMaxLength(30);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<TblExpense>(entity =>
        {
            entity.ToTable("tblExpense", tb => tb.HasTrigger("UpdateLatestVoucherNumber"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdvancePurchaseNo).HasMaxLength(30);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.ChequeDate).HasColumnType("date");
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.IsCashCheque).HasComment("0= Cash, 1= Cheque");
            entity.Property(e => e.IsDueAdvance).HasComment("0= Due= False, 1= Advance= True");
            entity.Property(e => e.PurchaseOrderNo).HasMaxLength(30);
            entity.Property(e => e.ReceiveDate).HasColumnType("date");
            entity.Property(e => e.SalesOrderNo).HasMaxLength(30);
            entity.Property(e => e.SupplierBillDate).HasColumnType("date");
            entity.Property(e => e.SupplierBillNo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("date");
            entity.Property(e => e.VoucherNumber).HasMaxLength(30);

            entity.HasOne(d => d.BankAccount).WithMany(p => p.TblExpenses)
                .HasForeignKey(d => d.BankAccountId)
                .HasConstraintName("FK_tblExpense_tblBankAccountOwner");

            entity.HasOne(d => d.Person).WithMany(p => p.TblExpenses)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_tblExpense_tblEmployee");
        });

        modelBuilder.Entity<TblExpenseDetail>(entity =>
        {
            entity.ToTable("tblExpenseDetails");

            entity.Property(e => e.Particulars).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

            entity.HasOne(d => d.Expense).WithMany(p => p.TblExpenseDetails)
                .HasForeignKey(d => d.ExpenseId)
                .HasConstraintName("FK_tblExpenseDetails_tblExpense");
        });

        modelBuilder.Entity<TblFormName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FormList");

            entity.ToTable("tblFormName");

            entity.Property(e => e.FormName).HasMaxLength(30);
        });

        modelBuilder.Entity<TblOfficeExpenceHead>(entity =>
        {
            entity.ToTable("tblOfficeExpenceHead");

            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.ExpenceType)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<TblOwner>(entity =>
        {
            entity.ToTable("tblOwner");

            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.Owners).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<TblPurchaseOrder>(entity =>
        {
            entity.ToTable("tblPurchaseOrder", tb =>
                {
                    tb.HasTrigger("UpdateLatestPurchaseOrderNo");
                    tb.HasTrigger("UpdateLatestPurchaseOrderNo_x");
                });

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.PurchaseOrderDate).HasColumnType("date");
            entity.Property(e => e.PurchaseOrderNo).HasMaxLength(50);
            entity.Property(e => e.SalesOrderNo).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("date");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.TblPurchaseOrders)
                .HasForeignKey(d => d.SalesOrderId)
                .HasConstraintName("FK_tblPurchaseOrder_tblSaleOrder");

            entity.HasOne(d => d.Supplier).WithMany(p => p.TblPurchaseOrders)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_tblPurchaseOrder_tblSupplier");
        });

        modelBuilder.Entity<TblRefundExpense>(entity =>
        {
            entity.ToTable("tblRefundExpense", tb => tb.HasTrigger("UpdateLatestVoucherNumbertblRefunExpense"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BillAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.PurchaseNo).HasMaxLength(30);
            entity.Property(e => e.ReceiveDate).HasColumnType("date");
            entity.Property(e => e.RefundAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesOrderNo).HasMaxLength(30);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
            entity.Property(e => e.VoucherNumber).HasMaxLength(30);
        });

        modelBuilder.Entity<TblRevenue>(entity =>
        {
            entity.ToTable("tblRevenue", tb => tb.HasTrigger("UpdateLatestVoucherNumberRevenue"));

            entity.Property(e => e.AdvanceAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Aitamunt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("AITAmunt");
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BankReceiveDate).HasColumnType("date");
            entity.Property(e => e.BillAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.BillDate).HasColumnType("date");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.ChequeDate).HasColumnType("date");
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.NetBill).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PayOrderDate).HasColumnType("date");
            entity.Property(e => e.PayOrderNo).HasMaxLength(50);
            entity.Property(e => e.ReceiveDate).HasColumnType("date");
            entity.Property(e => e.SalesOrderNo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("date");
            entity.Property(e => e.VatTaxAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSaleOrder>(entity =>
        {
            entity.ToTable("tblSaleOrder", tb => tb.HasTrigger("UpdateLatestSalesOrderNo"));

            entity.HasIndex(e => e.SalesOrderNo, "UC_SalesOrderNO").IsUnique();

            entity.Property(e => e.AppWorkValue).HasMaxLength(50);
            entity.Property(e => e.ClosingDate)
                .HasColumnType("date")
                .HasColumnName("closingDate");
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.PlaceofWork).HasMaxLength(50);
            entity.Property(e => e.ProjectCloseDate).HasColumnType("date");
            entity.Property(e => e.ProjectName).HasMaxLength(50);
            entity.Property(e => e.SalesOrderNo).HasMaxLength(10);
            entity.Property(e => e.Startdate).HasColumnType("date");
            entity.Property(e => e.TypeOfWork).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("date");

            entity.HasOne(d => d.Cleint).WithMany(p => p.TblSaleOrders)
                .HasForeignKey(d => d.CleintId)
                .HasConstraintName("FK_tblSaleOrder_tblClient");

            entity.HasOne(d => d.Company).WithMany(p => p.TblSaleOrders)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_tblSaleOrder_tblCompany");

            entity.HasOne(d => d.Owners).WithMany(p => p.TblSaleOrders)
                .HasForeignKey(d => d.OwnersId)
                .HasConstraintName("FK_tblSaleOrder_tblOwner");

            entity.HasOne(d => d.Pm).WithMany(p => p.TblSaleOrders)
                .HasForeignKey(d => d.PmId)
                .HasConstraintName("FK_tblSaleOrder_tblEmployee");

            entity.HasOne(d => d.UpdateUser).WithMany(p => p.TblSaleOrders)
                .HasForeignKey(d => d.UpdateUserId)
                .HasConstraintName("FK_tblSaleOrder_tblUser");
        });

        modelBuilder.Entity<TblSupplier>(entity =>
        {
            entity.ToTable("tblSupplier");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.Mobile).HasMaxLength(100);
            entity.Property(e => e.OwnerName).HasMaxLength(100);
            entity.Property(e => e.SupplerCode).HasMaxLength(10);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.Telephone).HasMaxLength(100);
            entity.Property(e => e.TypeOfWork).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.ToTable("tblUser");

            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(20);
        });

        modelBuilder.Entity<TblUserPermissionMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserPermissionMapping");

            entity.ToTable("tblUserPermissionMapping");

            entity.HasOne(d => d.Form).WithMany(p => p.TblUserPermissionMappings)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPermissionMapping_FormList");

            entity.HasOne(d => d.Role).WithMany(p => p.TblUserPermissionMappings)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPermissionMapping_UserRole");
        });

        modelBuilder.Entity<TblUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserRole");

            entity.ToTable("tblUserRole");

            entity.Property(e => e.RoleName).HasMaxLength(20);
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Particulars).HasMaxLength(50);
        });

        modelBuilder.Entity<VwExpenseinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_expenseinfo");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PurchaseOrderNo).HasMaxLength(30);
            entity.Property(e => e.SalesOrderNo).HasMaxLength(30);
            entity.Property(e => e.VoucherNumber).HasMaxLength(30);
        });

        modelBuilder.Entity<VwPurchaseinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_purchaseinfo");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AppWorkValue).HasMaxLength(50);
            entity.Property(e => e.ClientCode).HasMaxLength(50);
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .HasColumnName("clientName");
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.PlaceofWork).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(50);
            entity.Property(e => e.PurchaseOrderDate).HasColumnType("date");
            entity.Property(e => e.PurchaseOrderNo).HasMaxLength(50);
            entity.Property(e => e.SalesOrderNo).HasMaxLength(20);
            entity.Property(e => e.Startdate).HasColumnType("date");
            entity.Property(e => e.SupplerCode).HasMaxLength(10);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.TypeOfWork).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<VwSalesInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesInfo");

            entity.Property(e => e.AppWorkValue).HasMaxLength(50);
            entity.Property(e => e.ClientCode).HasMaxLength(50);
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .HasColumnName("clientName");
           
            entity.Property(e => e.EmployeeName).HasMaxLength(100);
            entity.Property(e => e.Owners).HasMaxLength(50);
            entity.Property(e => e.PlaceofWork).HasMaxLength(50);
            entity.Property(e => e.ProjectCloseDate).HasColumnType("date");
            entity.Property(e => e.ProjectName).HasMaxLength(50);
            entity.Property(e => e.SalesOrderNo).HasMaxLength(10);
            entity.Property(e => e.Startdate).HasColumnType("date");
            entity.Property(e => e.TypeOfWork).HasMaxLength(50);
        });

        modelBuilder.Entity<VwSalesOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_sales_Order");

            entity.Property(e => e.AppWorkValue).HasMaxLength(50);
            entity.Property(e => e.ClientName)
                .HasMaxLength(40)
                .HasColumnName("clientName");
            entity.Property(e => e.ClosingDate)
                .HasColumnType("date")
                .HasColumnName("closingDate");
            entity.Property(e => e.Createdate).HasColumnType("date");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Owners).HasMaxLength(50);
            entity.Property(e => e.PlaceofWork).HasMaxLength(50);
            entity.Property(e => e.Pmid).HasColumnName("PMId");
            entity.Property(e => e.SalesOrderNo).HasMaxLength(10);
            entity.Property(e => e.Startdate).HasColumnType("date");
            entity.Property(e => e.TypeOfWork).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("date");
        });

        modelBuilder.Entity<IntReturn>().HasNoKey();
        modelBuilder.Entity<sp_GetPatternConfig>().HasNoKey();
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
