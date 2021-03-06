namespace InventoryFinal.Migrations.ApplicationDb
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InventoryFinal.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\ApplicationDb";
        }

        protected override void Seed(/*InventoryFinal.Models.ApplicationDbContext*/InventoryFinal.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //context.Roles.AddOrUpdate(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            //{
            //    Name = "Admin"
            //});
            //context.Roles.AddOrUpdate(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            //{
            //    Name = "User"
            //});
            //context.Roles.AddOrUpdate(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            //{
            //    Name = "Employee"
            //});
        }
    }
}
