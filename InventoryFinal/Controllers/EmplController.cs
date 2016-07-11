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
        // GET: Empl
        public ActionResult Index()
        {

            return View();
        }
    }
}