using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using InventoryFinal.Models;

namespace InventoryFinal.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Roles
        public ActionResult Index()
        {
            return View(context.Roles.ToList());
        }

        // GET: Roles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                context.Roles.Add(new IdentityRole()
                {
                    Name = collection["RoleName"]
                });
                context.SaveChanges();
                ViewBag.ResultMessage = "Role Created Successfully !";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ManageUserRoles()
        {
            ViewBag.RoleName = new SelectList(context.Roles.OrderBy(r=>r.Name).ToList(), "Id", "Name");
            //ViewBag.Users = new SelectList(context.Users.OrderBy(u => u.UserName).ToList(), "Id", "UserName");
            ViewBag.Users = context.Users.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult RoleAddToUser(FormCollection collection)
        {
            //ApplicationUser user = context.Users.Where(u=>u.Id.Equals(collection[]))

            return View();
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Roles/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        
        // POST: Roles/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {

                // TODO: Add delete logic here
                var role = (from r in context.Roles
                           where r.Id == id
                           select r).Single();
                context.Roles.Remove(role);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
