using BanFramework.Mssql.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramwork.Mssql.Business.ValidationRules.FluentValidation
{
    public class ProdactionValidatior : AbstractValidator<Product>
    {
        public void ProductValidatior()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.ProductNumber).Null();
                     
        }

        private bool StartWith(string arg)
        {
            return arg.StartsWith("A");
        }
    }

}
