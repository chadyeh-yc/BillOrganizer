using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillOrganizer.Models;
using BillOrganizer.Models.ViewModels;

namespace BillOrganizer.Controllers
{
    public class BillorganizerController : Controller
    {
        // GET: Billorganizer
        public ActionResult Index()
        {
            return View();
        }

        private readonly JournalEntries journalEntries = new JournalEntries();

        [ChildActionOnly]
        public ActionResult ShowHistory()
        {
            var result = journalEntries.AccountBook.Take(100).Select(c => new BillorganizerViewModel
            {
                 Type = c.Categoryyy == 1 ? BillType.支出 : BillType.收入,
                 Amount = c.Amounttt,
                 Date = c.Dateee,
                 Remark = c.Remarkkk,
            }).ToList();
            return View(result);
        }
    }
}