using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AAController : Controller
    {
        // GET: AA
        public ActionResult Index()
        {

            AdventureWorks2019Entities db = new AdventureWorks2019Entities();
            var item = db.Addresses.ToList();
            List<Address> Addresses = db.Addresses.ToList();
            return View(item);

        }
    }
}