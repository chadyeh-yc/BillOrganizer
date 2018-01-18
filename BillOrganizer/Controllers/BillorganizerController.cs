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

        [ChildActionOnly]
        public ActionResult ShowHistory()
        {
            var history = new List<Models.ViewModels.BillorganizerViewModel>
            {
                new Models.ViewModels.BillorganizerViewModel {Type=Models.ViewModels.BillType.收入, Amount=100, Date = new DateTime(2017,4,10), Remark="發傳單" },
                new Models.ViewModels.BillorganizerViewModel {Type=Models.ViewModels.BillType.支出, Amount=40, Date = new DateTime(2017,4,11), Remark="咖啡" },
            };

            return View(history);
        }
    }
}