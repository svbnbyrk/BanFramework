using BanFramework.Mssql.Business.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BanFramework.Mssql.Entities.Concrete;
using BanFramework.Mssql.DataAccess.Abstrack;
using BanFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using BanFramework.Mssql.Business.ValidationRules.FluentValidation;
using BanFramework.Core.Aspects.PostSharp;
using BanFramework.Core.Aspects.PostSharp.TransactionAspects;
using BanFramework.Core.Aspects.PostSharp.ValidationAspects;
using BanFramework.Core.DataAccess;

namespace BanFramework.Mssql.Business.Concert.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _object;
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal @object)
        {
            this._object = @object;
        }

        public ProductManager(IProductDal productDal, IQueryableReporsitory<Product> queryable)
        {
            _productDal = productDal;
            //_queryable = queryable;
        }

        [FluentValidationAspect(typeof(ProductionValidator))]
        public Product Add(Product product)
        {
            //ValidatorTool.FluentValidate(new ProductionValidator(), product);
            return _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidationAspect(typeof(ProductionValidator))]
        public Product Update(Product product)
        {
            ////işkuralları yazılır
            //ValidatorTool.FluentValidate(new ProductionValidator(), product);
            return _productDal.Update(product);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);

            _productDal.Update(product2);


            //using (TransactionScope scope = new TransactionScope())
            //{
            //    try
            //    {
            //        _productDal.Add(product1);

            //        _productDal.Update(product2);

            //        scope.Complete();
            //    }
            //    catch 
            //    {
            //        scope.Dispose();
            //    }
            //}


        }

    }
}
