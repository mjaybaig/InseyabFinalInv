using InventoryFinal.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryFinal.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminiController : Controller
    {
        InventoryDBContext icontext = new InventoryDBContext();
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Admini
        public ActionResult Index()
        {
            InventoryDBContext context = new InventoryDBContext();

            //gather data for admin dashboard

            ViewBag.Employees = (from a in context.Employees
                                join e in context.Employees on a.ReportsToID equals e.EmployeeID
                                select new EmployeeListViewModel
                                {
                                    FirstName = a.FirstName,
                                    LastName = a.LastName,
                                    Birthdate = (DateTime)a.Birthdate,
                                    City = a.City,
                                    ReportsToName = e.FirstName,
                                    EmployeesID = a.EmployeeID
                                }).ToList();
            ViewBag.Products = context.Products.Take(4).ToList();
            ViewBag.Orders = context.OrderDetails.ToList();

            //determine if any product is low
            var lowproduct = (from p in context.Products
                             where p.UnitsInStock < 10
                             select p).ToList();
            ViewBag.LowProducts = lowproduct;
            return View();
        }


        public ContentResult EmpUserSync()
        {

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var emp = icontext.Employees.ToList();

            foreach(var e in emp)
            {
                if((userManager.FindByName(e.FirstName+"_"+e.LastName) == null))
                {
                    var newUser = new ApplicationUser()
                    {
                        UserName = e.FirstName + "_" + e.LastName,
                        PhoneNumber = e.HomePhone
                    };
                    string newPwd = "Today123";

                    var chkUser = userManager.Create(newUser, newPwd);
                    if (!chkUser.Succeeded)
                    {
                        return Content("chkuser didnt succeed");
                    }

                    if (chkUser.Succeeded)
                    {
                        var result1 = userManager.AddToRole(newUser.Id, "Employee");
                    }else
                    {
                        return Content("result1 didn't succeed");
                    }
                }
            }

            return Content("Users transfered. Press Back to go back");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
                icontext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}