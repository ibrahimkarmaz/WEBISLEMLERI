﻿using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=DbCoreFood;integrated security=true");
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
