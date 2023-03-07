using System;
using System.Collections.Generic;
using FrostlineECommerce.App.Entitiy.Concrete;

namespace FrostlineECommerce.Models
{
    public class ViewModel
    {
        public List<Product> Product { get; set; }
        public List<Category> Category { get; set; }
        public List<Period> Period { get; set; }
        public List<Discount> Discount { get; set; }
    }
}
