using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Models;

namespace Warehouse_Core.Context
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {
        }

        public DbSet<Storage> Storages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Storage>().ToTable("Storages");
            modelBuilder.Entity<User>().ToTable("Users");


        }

        //Create new table - add DBSet to class WarehouseContext, add Entity in method OnModelCreating
        // Add-Migration and Update-Database, check in DB if table is there
    }
}
