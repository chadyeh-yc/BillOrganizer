using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillOrganizer.Models.ViewModels;

namespace BillOrganizer.Models
{
    public class JournalEntriesService
    {
        private readonly JournalEntries journalEntries = new JournalEntries();
        
        public IList<BillorganizerViewModel> GetTop100JournalEntries()
        {
            var result = journalEntries.AccountBook.Take(100).Select(c => new BillorganizerViewModel
            {
                Type = c.Categoryyy == 1 ? BillType.支出 : BillType.收入,
                Amount = c.Amounttt,
                Date = c.Dateee,
                Remark = c.Remarkkk,
            }).ToList();
            return result;
        }
    }
}