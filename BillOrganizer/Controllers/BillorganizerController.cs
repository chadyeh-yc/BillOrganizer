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
            var history = new List<Models.ViewModels.BillorganizerViewModel>();
            Random rnd = new Random();
            Models.ViewModels.BillType BillType;
            for (int i = 0; i < 100; i++)
            {
                if (rnd.Next(2) == 0)
                {
                    BillType = Models.ViewModels.BillType.支出;
                }
                else
                {
                    BillType = Models.ViewModels.BillType.收入;
                }
                var BillorganizerItem = new Models.ViewModels.BillorganizerViewModel
                {
                    Type = BillType,
                    Amount = rnd.Next(9999999),
                    Date = new DateTime(2016, 1, 1).AddDays(rnd.Next(900)),
                    Remark = @"Item" + i.ToString()
                };
                history.Add(BillorganizerItem);
            }



            return View(history);
        }
    }
}