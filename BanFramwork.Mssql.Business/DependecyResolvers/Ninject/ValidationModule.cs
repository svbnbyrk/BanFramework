using BanFramework.Mssql.Entities.Concrete;
using BanFramwork.Mssql.Business.ValidationRules.FluentValidation;
using FluentValidation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramwork.Mssql.Business.DependecyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProdactionValidatior>().InSingletonScope();
        }
    }
}
