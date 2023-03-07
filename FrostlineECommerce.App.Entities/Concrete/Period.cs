using System;
namespace FrostlineECommerce.App.Entitiy.Concrete
{
    public class Period : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
