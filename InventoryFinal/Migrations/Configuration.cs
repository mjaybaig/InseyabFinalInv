namespace InventoryFinal.Migrations
{
    using InventoryFinal.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InventoryFinal.Models.InventoryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(InventoryFinal.Models.InventoryDBContext context)
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
            context.Categories.AddOrUpdate(c => c.CatID,
                new Categories { CatID = 1, Name = "Foods", Description = "All edible and drinkable items that are eaten independatly as units" },
                new Categories { CatID = 2, Name = "Spices", Description = "All items that are used to season Foods" },
                new Categories { CatID = 3, Name = "Toys", Description = "All childrens items"}
                );
            context.Suppliers.AddOrUpdate(s => s.SupplierID,
                new Suppliers { SupplierID = 1, ContactName = "Asif Bajwa", CompanyName = "Engro Foods", Address = "Sample Address 1", City = "Sialkot", ContactTitle = "Mr.", Country = "Pakistan", fax = "263541654", homePage = "http://www.engrofoods.com", Phone = "31535135", PostalCode = "3215", Region = "Punjab" },
                new Suppliers { SupplierID = 2, ContactName = "Yasser Karim", CompanyName = "Mitsubishi Corp", Address = "Sample Address 2", City = "Karachi", ContactTitle = "Mr.", Country = "Pakistan", fax = "263541654", homePage = "http://www.mitsubishi.com", Phone = "31535135", PostalCode = "3215", Region = "Sindh" }
                );
            context.Products.AddOrUpdate(p => p.ProductID,
                new Products { ProductID = 1, CategoryID = 1, ProductName = "Lays Chips", Discontinued = false, QuantityPerUnit = 250, SupplierID = 1, ReorderLevel = 25, UnitPrice = 15.0m, UnitsInOrder = 18, UnitsInStock = 150 },
                new Products { ProductID = 2, CategoryID = 1, ProductName = "Doritos", Discontinued = false, QuantityPerUnit = 250, SupplierID = 1, ReorderLevel = 15, UnitPrice = 60.0m, UnitsInOrder = 30, UnitsInStock = 200 },
                new Products { ProductID = 3, CategoryID = 3, ProductName = "Lancer", Discontinued = false, QuantityPerUnit = 125, SupplierID = 2, ReorderLevel = 10, UnitPrice = 150.0m, UnitsInOrder = 13, UnitsInStock = 175 }
                );
            context.Employees.AddOrUpdate(e => e.EmployeeID,
                new Employees { EmployeeID = 1, FirstName = "Kumail", LastName = "Habib", Birthdate = new DateTime(1984, 12, 23), Hiredate = new DateTime(2006, 8, 1), Address = "Sample Address here", City = "Lahore", Country = "Pakistan", HomePhone = "925485259", Title = "Mr.", Region = "Sindh", Extension = "457" },
                new Employees { EmployeeID = 2, FirstName = "Hamid", LastName = "Shareef", Birthdate = new DateTime(1988, 1, 7), Hiredate = new DateTime(2011, 5, 10), Address = "Sample Address52 here", City = "Lahore", Country = "Pakistan", HomePhone = "92548847", Title = "Mr.", Region = "Sindh", Extension = "458" }
                );
            context.SaveChanges();
        }
    }
}
