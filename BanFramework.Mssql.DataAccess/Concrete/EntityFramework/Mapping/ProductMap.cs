using BanFramework.Mssql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Mssql.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Product", @"Production");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.ProductNumber).HasColumnName("ProductNumber");
            Property(x => x.Color).HasColumnName("Color");
            
        }

    }
}
