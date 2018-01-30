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
        private readonly JournalEntries _journalEntries;
        private readonly IRepository<AccountBook> _repository;
        private readonly IUnitOfWork _iunitOfWork;

        public JournalEntriesService(IUnitOfWork unitOfWork)
        {
            _journalEntries = new JournalEntries();
            _iunitOfWork = unitOfWork;
            _repository = new Repository<AccountBook>(_iunitOfWork);
        }

        public IList<BillorganizerViewModel> GetNumberOfJournalEntries(int numberOfEntry)
        {
            var source = _repository.LookupAll();
            var result = source.OrderByDescending(c => c.Dateee).ThenByDescending(c => c.Id).Take(numberOfEntry).Select(c => new BillorganizerViewModel
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
            _iunitOfWork.Save();
        }
}
}