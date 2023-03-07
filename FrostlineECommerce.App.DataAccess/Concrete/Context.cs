using System;
using FrostlineECommerce.App.Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FrostlineECommerce.App.DataAccess.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=ECommerceDb;Username=root;Password=pass1234;");

        }


        public DbSet<Category> Category { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Period> Period { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
