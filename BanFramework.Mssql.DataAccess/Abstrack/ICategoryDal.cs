using BanFramework.Core.DataAccess;
using BanFramework.Mssql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Mssql.DataAccess.Abstrack
{
    public interface ICategoryDal:IEntityRepository<Category>
    {

    }
}
