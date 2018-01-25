using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillOrganizer.Models;
using BillOrganizer.Models.ViewModels;
using BillOrganizer.Repositories;

namespace BillOrganizer.Controllers
{
    public class BillorganizerController : Controller
    {
        // GET: Billorganizer
        public ActionResult Index()
        {
            return View();
        }

        private readonly JournalEntriesService journalEntriesService = new JournalEntriesService(new EFUnitOfWork());

        [ChildActionOnly]
        public ActionResult ShowHistory()
        {
            var result = journalEntriesService.GetTop100JournalEntries();
            return View(result);
        }
    }
}