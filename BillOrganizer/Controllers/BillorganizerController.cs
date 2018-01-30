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

        private readonly JournalEntriesService _journalEntriesService;
        public BillorganizerController()
        {
            var _unitOfWork = new EFUnitOfWork();
            _journalEntriesService = new JournalEntriesService(_unitOfWork);
        }

        [ChildActionOnly]
        public ActionResult ShowHistory()
        {
            var result = _journalEntriesService.GetNumberOfJournalEntries(100);
            return View(result);
        }
    }
}