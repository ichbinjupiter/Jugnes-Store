using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace JugnesStore.Models
{
    public partial class JugnesModel : DbContext
    {
        public JugnesModel()
            : base("name=JugnesModel")
        {
        }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<ManagerType> ManagerTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCart> UserCarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
