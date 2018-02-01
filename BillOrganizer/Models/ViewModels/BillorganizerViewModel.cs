using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BillOrganizer.Models.ViewModels
{
    public class BillorganizerViewModel
    {
        [Required]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [Range(1, int.MaxValue, ErrorMessage = "輸入數值，請大於{1}")]
        [Display(Name = "金額")]
        public decimal Amount { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [DateValidation()]
        [Display(Name = "日期")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "請勿輸入超過100個字元")]
        [Display(Name = "備註")]
        public string Remark { get; set; }

        [Required]
        [Display(Name = "類別")]
        public BillType Type { get; set; }
    }

    public enum BillType
    {
        收入,
        支出
    }

    //筆記兩個日期的ValidationAttribute https://forums.asp.net/t/1557868.aspx?Custom+DateTime+ValidationAttribute
    public class DateValidationAttribute : ValidationAttribute
    {
        // Fields
        private DateTime _dateTime;
        // Constructors
        public DateValidationAttribute()
        {
            _dateTime = DateTime.Now;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
         {
            if (DateTime.TryParse(value.ToString(), out DateTime dateValue))
            {
                if (dateValue.Date <= _dateTime.Date)
                {
                    // valid
                    return ValidationResult.Success;
                }
                else
                {
                    // invalid
                    var errorMsg = string.Format($"您輸入的日期{dateValue.ToString("yyyy/MM/dd")}大於{_dateTime.ToString("yyyy/MM/dd")}");
                    return new ValidationResult(errorMsg);
                }
            }
            else
            {
                // invalid
                var errorMsg = string.Format($"您輸入{value.ToString()}不是日期格式yyyy/MM/dd");
                return new ValidationResult(errorMsg);
            }
        }
     }
}