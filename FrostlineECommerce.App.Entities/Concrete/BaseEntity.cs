using System;
namespace FrostlineECommerce.App.Entitiy.Concrete
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
