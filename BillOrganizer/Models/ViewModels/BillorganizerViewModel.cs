using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BillOrganizer.Models.ViewModels
{
    public class BillorganizerViewModel
    {
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
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