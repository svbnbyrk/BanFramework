using BanFramework.Mssql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramwork.Mssql.Business.Abstrack
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetbyId(int id);
        Product Add(Product producy);
        Product Update(Product producy);
    }
}
