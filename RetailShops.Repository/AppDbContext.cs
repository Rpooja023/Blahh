﻿using Microsoft.EntityFrameworkCore;
using RetailShops.Repository.Entities;

namespace RetailShops.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}