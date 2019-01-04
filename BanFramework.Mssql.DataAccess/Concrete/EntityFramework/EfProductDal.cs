using BanFramework.Mssql.DataAccess.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanFramework.Mssql.Entities.Concrete;
using System.Linq.Expressions;
using BanFramework.Core.DataAccess.EntityFramework;
using BanFramework.Mssql.Entities.ComplexType;

namespace BanFramework.Mssql.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, BanContext>, IProductDal
    {
        public List<ProductDetail> GetCostHistory()
        {
            using (BanContext context = new BanContext())
            {
                var result = from p in context.Products
                             join c in context.ProductCategories on p.ProductId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.Name,
                             };

                return result.ToList();

            }
        }
    }
}
