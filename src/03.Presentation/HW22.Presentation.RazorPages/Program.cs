using HW22.Domain.AppServices;
using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Contracts.Repository;
using HW22.Domain.Core.Contracts.Servcie;
using HW22.Domain.Core.Entities;
using HW22.Domain.Services;
using HW22.framework;
using HW22.Infra.Data.Repos.Ef;
using HW22.Infra.Db.SqlServer.Ef;
using HW22.Presentation.RazorPages.Extentions;
using HW22.Presentation.RazorPages.Middlewares;
using HW22.Presentation.RazorPages.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;

var builder = WebApplication.CreateBuilder(args);


builder.Host.UseSerilog((context, services, configuration) =>
{
    configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext();
});

// Add services to the container.
builder.Services.AddRazorPages();

#region ServiceRegisteration

builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HW24;User ID=sa;Password=Az@r4180;Trust Server Certificate=True "));

builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>(
    options =>
    {
        options.SignIn.RequireConfirmedEmail = false;
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 7;
        options.Password.RequireNonAlphanumeric = false;
        options.User.RequireUniqueEmail = false;
    })
    .AddErrorDescriber<PersianIdentityErrorDescriber>()
    .AddEntityFrameworkStores<AppDbContext>();



builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IFileService, FileService>();

builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IProductAppService, ProductAppService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IUserAppService, UserAppService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IOrderAppService, OrderAppService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IOrderItemAppService, OrderItemAppService>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();


builder.Services.AddScoped<IWalletService, WalletService>();
builder.Services.AddScoped<IWalletRepository, WalletRepository>();

builder.Services.AddScoped<ICookieService, CookieService>();

builder.Services.AddScoped<IBasketService, BasketService>();
builder.Services.AddSession();
#endregion

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();

app.UseMiddleware<LoggingMiddleware>();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();



app.MapGet("/", (context) =>
{
    context.Response.Redirect("/Home/Index");
    return Task.CompletedTask;
});


app.Run();
