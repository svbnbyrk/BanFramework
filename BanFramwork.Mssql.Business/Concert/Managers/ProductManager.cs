using BanFramwork.Mssql.Business.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanFramework.Mssql.Entities.Concrete;
using BanFramework.Mssql.DataAccess.Abstrack;
using BanFramework.Core.CrossCuttingConcerns.Validation.FluenValidation;
using BanFramwork.Mssql.Business.ValidationRules.FluentValidation;
using BanFramework.Core.Aspects.PostSharp;

namespace BanFramwork.Mssql.Business.Concert.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager (IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProdactionValidatior))]
        public Product Add(Product product)
        {
            //ValidatorTool.FluentValidate(new ProdactionValidatior(), product);
            return _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetbyId(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidationAspect(typeof(ProdactionValidatior))]
        public Product Update(Product product)
        {
            ////işkuralları yazılır
            //ValidatorTool.FluentValidate(new ProdactionValidatior(), product);
            return _productDal.Update(product);
        }
    }
}
