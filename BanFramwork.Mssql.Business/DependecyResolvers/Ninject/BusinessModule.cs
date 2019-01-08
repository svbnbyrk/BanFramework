using System.Data.Entity;
using BanFramework.Core.DataAccess;
using BanFramework.Core.DataAccess.EntityFramework;
using BanFramework.Mssql.Business.Abstrack;
using BanFramework.Mssql.Business.Concert.Managers;
using BanFramework.Mssql.DataAccess.Abstrack;
using BanFramework.Mssql.DataAccess.Concrete;
using BanFramework.Mssql.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace BanFramework.Mssql.Business.DependecyResolvers.Ninject
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
