using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillOrganizer.Models.ViewModels;
using BillOrganizer.Repositories;

namespace BillOrganizer.Models
{
    public class JournalEntriesService
    {
        private readonly JournalEntries journalEntries;
        private readonly IRepository<AccountBook> repository;
        private readonly IUnitOfWork iunitOfWork;

        public JournalEntriesService(IUnitOfWork unitOfWork)
        {
            journalEntries = new JournalEntries();
            iunitOfWork = unitOfWork;
            repository = new Repository<AccountBook>(iunitOfWork);
        }

        public IList<BillorganizerViewModel> GetTop100JournalEntries()
        {
            var source = repository.LookupAll();
            var result = source.Take(100).Select(c => new BillorganizerViewModel
            {
                Type = c.Categoryyy == 1 ? BillType.支出 : BillType.收入,
                Amount = c.Amounttt,
                Date = c.Dateee,
                Remark = c.Remarkkk,
            }).ToList();
            return result;
        }

        public void Save()
        {
            iunitOfWork.Save();
        }
}
}