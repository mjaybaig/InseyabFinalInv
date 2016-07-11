using InventoryFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryFinal.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmplController : Controller
    {
        InventoryDBContext context = new InventoryDBContext();
        ApplicationDbContext acontext = new ApplicationDbContext();
        // GET: Empl
        public ActionResult Index()
        {
            var curUser = (from u in acontext.Users
                          where u.UserName == User.Identity.Name
                          select u).Single();

            ViewBag.Orders = (from o in context.OrderDetails
                             where o.Order.Employee.HomePhone == curUser.PhoneNumber
                             select o).ToList();

            return View();
        }
    }
}