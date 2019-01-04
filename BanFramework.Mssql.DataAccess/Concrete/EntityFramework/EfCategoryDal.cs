using BanFramework.Core.DataAccess.EntityFramework;
using BanFramework.Mssql.DataAccess.Abstrack;
using BanFramework.Mssql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Mssql.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category, BanContext>,ICategoryDal
    {

    }
}
