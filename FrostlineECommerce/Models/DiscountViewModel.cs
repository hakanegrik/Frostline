using System;
using System.Collections.Generic;

namespace FrostlineECommerce.Models
{
    public class DiscountViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PeriodName { get; set; }
        public int PeriodId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public int DiscountRate { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
