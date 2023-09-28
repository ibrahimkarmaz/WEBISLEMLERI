﻿using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS;database=DBNewOopCore1;Trusted_Connection=true");
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}