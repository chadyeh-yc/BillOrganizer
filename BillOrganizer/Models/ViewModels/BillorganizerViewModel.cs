using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillOrganizer.Models.ViewModels
{
    public class BillorganizerViewModel
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }
        public BillType Type { get; set; }
    }

    public enum BillType
    {
        收入,
        支出
    }
}