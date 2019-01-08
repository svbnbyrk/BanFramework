using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BanFramework.Mssql.DataAccess.Abstrack;
using BanFramework.Mssql.Business.Concert.Managers;
using BanFramework.Mssql.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace BanFramework.Mssql.Business.Tests
{
    [TestClass]
    public class ProductManagerTests

    {   
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            var mock = new Mock<IProductDal>();
            var productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
