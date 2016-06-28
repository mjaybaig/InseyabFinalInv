using System;
using Microsoft.Owin;
using Owin;
using InventoryFinal.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(InventoryFinal.Startup))]
namespace InventoryFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesAndUsers();
        }

        private void createRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Create Admin role if already not exists
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole()
                {
                    Name = "Admin"
                };

                roleManager.Create(role);
            }
            //create jameel user if not already exists
            if(userManager.FindByName("Jameelbaig") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "Jameelbaig";
                user.Email = "Jameelbaig@inseyab.com";
                string userpwd = "abcd123";

                var chkUser = userManager.Create(user, userpwd);

                //Add this user to Admin role
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");
                }
            }

            //Add Employee Role
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new IdentityRole()
                {
                    Name = "Employee"
                };
                roleManager.Create(role);
            }
        }
    }
}
