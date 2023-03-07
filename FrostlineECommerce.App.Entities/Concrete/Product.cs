using System;
namespace FrostlineECommerce.App.Entitiy.Concrete
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public int Price { get; set; }
    }
}
