﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PGL58P1\MSSQLSERVERK;Initial Catalog=Test;Trusted_Connection=true");
        }

        public DbSet<Sti> STI { get; set; }
        public DbSet<Stk> STK { get; set; }
    }
}
