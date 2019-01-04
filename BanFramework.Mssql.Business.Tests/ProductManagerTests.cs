using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BanFramework.Mssql.DataAccess.Abstrack;
using BanFramwork.Mssql.Business.Concert.Managers;
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
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
