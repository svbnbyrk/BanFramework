using BanFramework.Mssql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Mssql.Business.Abstrack
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product producy);
        Product Update(Product producy);
    }
}
