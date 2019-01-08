using BanFramework.Core.DataAccess;
using BanFramework.Core.DataAccess.EntityFramework;
using BanFramework.Mssql.DataAccess.Abstrack;
using BanFramework.Mssql.DataAccess.Concrete;
using BanFramework.Mssql.DataAccess.Concrete.EntityFramework;
using BanFramwork.Mssql.Business.Abstrack;
using BanFramwork.Mssql.Business.Concert.Managers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramwork.Mssql.Business.DependecyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind(typeof(IQueryableReporsitory<>)).To(typeof(EfQueryablaRepository<>));
            Bind<DbContext>().To<BanContext>();

            //Bind<Something ORM>().To<something sql helper> ();
        }

    }
}
