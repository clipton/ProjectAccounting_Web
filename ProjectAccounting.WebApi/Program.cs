using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectAccounting.BusinessModel;
using ProjectAccounting.Models.Models;
using System.Text.Json.Serialization;
//using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


//builder.Services.AddControllers().AddNewtonsoftJson(options =>
//{
//    //customize settings here. For example, change the naming strategy

//    options.SerializerSettings.ContractResolver = new DefaultContractResolver()
//    {
//        NamingStrategy = new SnakeCaseNamingStrategy()
//    };
//});

//builder.Services.AddControllers().AddNewton
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRoleService, UserRoleService>();
builder.Services.AddScoped<IRefundService, RefundService>();
builder.Services.AddScoped<IBillingService, BillingService>();
builder.Services.AddScoped<IRevenueService, RevenueService>();
builder.Services.AddScoped<ISalesService, SalesService>();
builder.Services.AddScoped<IPurchaseService, PurchaseService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<IExpenceService, ExpenceService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IOwnerService, OwnerService>();
builder.Services.AddScoped<ICommonService, CommonService>();
builder.Services.AddScoped<IMasterService, MasterService>();
builder.Services.AddScoped<IOfficeHeadService, OfficeHeadService>();
builder.Services.AddScoped<IBankAccountOwnerService, BankAccountOwnerService>();




//builder.Services.AddMvc()
//        .AddJsonOptions(
//            options => options.Serializer
//            Settings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
//        );



builder.Services.AddDbContext<ProjectAccountingContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
                    });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
