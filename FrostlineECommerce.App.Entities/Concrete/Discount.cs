using System;
namespace FrostlineECommerce.App.Entitiy.Concrete
{
    public class Discount : BaseEntity
    {
        public int DiscountRate { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int PeriodId { get; set; }
        public string PeriodName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
