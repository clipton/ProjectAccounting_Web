using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using ProjectAccounting.UI.Services;
using Blazored.LocalStorage;
using ProjectAccounting.Models.CustomModels;
using Blazored.SessionStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<EmployeeService>();
builder.Services.AddSingleton<ClientService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<UserRoleService>();
builder.Services.AddSingleton<SalesService>();
builder.Services.AddSingleton<PurchaseService>();
builder.Services.AddSingleton<ExpenceService>();
builder.Services.AddSingleton<SupplierService>();
builder.Services.AddSingleton<ClientService>();
builder.Services.AddSingleton<OwnerService>();
builder.Services.AddSingleton<CommonService>();
builder.Services.AddSingleton<MasterService>();
builder.Services.AddSingleton<OfficeHeadService>();
builder.Services.AddSingleton<BankAccountOwnerService>();
builder.Services.AddSingleton<BillingService>();
builder.Services.AddSingleton<RevenueService>();
builder.Services.AddSingleton<RefundService>();



builder.Services.AddHttpClient<ISalesService, SalesService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IPurchaseService, PurchaseService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IEmployeeService,EmployeeService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IUserService, UserService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IUserRoleService, UserRoleService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IExpenceService, ExpenceService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});

builder.Services.AddHttpClient<IOwnerService, OwnerService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IClientService, ClientService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<ISupplierService, SupplierService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<ICommonService, CommonService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IMasterService, MasterService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IOfficeHeadService, OfficeHeadService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IBankAccountOwnerService, BankAccountOwnerService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IBillingService, BillingService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IRevenueService, RevenueService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IRefundService, RefundService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
builder.Services.AddHttpClient<IClientService, ClientService>(client => {
    client.BaseAddress = new Uri("http://localhost:5272/");
});
//builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped<sessionstate>();
builder.Services.AddBlazoredSessionStorage();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
