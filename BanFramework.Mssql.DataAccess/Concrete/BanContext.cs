using BanFramework.Mssql.DataAccess.Concrete.EntityFramework.Mapping;
using BanFramework.Mssql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BanFramework.Mssql.DataAccess.Concrete
{
    public class BanContext : DbContext
    {
        public BanContext()
        {
            Database.SetInitializer<BanContext>(null);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> ProductCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());     
        }

    }
}
