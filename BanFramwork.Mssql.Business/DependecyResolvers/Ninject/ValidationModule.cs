using BanFramework.Mssql.Business.ValidationRules.FluentValidation;
using BanFramework.Mssql.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace BanFramework.Mssql.Business.DependecyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductionValidator>().InSingletonScope();
        }
    }
}
