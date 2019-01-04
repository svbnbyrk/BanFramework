using BanFramework.Mssql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Mssql.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CategoryMap: EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"ProductCategory", @"Production");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName("ProductCategoryId");
            Property(x => x.CategoryName).HasColumnName("Name");
            

        }
    }
}
