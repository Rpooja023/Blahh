using Microsoft.EntityFrameworkCore;
using RetailShops.Repository;
using RetailShops.Repository.Implementation;
using RetailShops.Repository.Interface;
using RetailShops.Service;
using RetailShops.Service.Implementation;
using RetailShops.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ProductRepository>();
builder.Services.AddTransient<OrderRepository>();
builder.Services.AddAutoMapper(typeof(ProductMap));
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => 
options.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=RetailShopDb;Trusted_Connection=True; TrustServerCertificate = True;", b => b.MigrationsAssembly("RetailShops.Repository")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
