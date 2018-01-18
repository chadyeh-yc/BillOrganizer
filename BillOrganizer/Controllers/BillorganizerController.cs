using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillOrganizer.Controllers
{
    public class BillorganizerController : Controller
    {
        // GET: Billorganizer
        public ActionResult Index()
        {
            return View();
        }
    }
}