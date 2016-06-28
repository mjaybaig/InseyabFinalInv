using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using InventoryFinal.Models; 

namespace InventoryFinal.Models
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext() : base("InseyabDbConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<InventoryDBContext>());
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Territories> Territories { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
    }
}