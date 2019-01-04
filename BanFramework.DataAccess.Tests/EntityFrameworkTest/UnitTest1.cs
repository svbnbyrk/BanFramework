using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BanFramework.Mssql.DataAccess.Concrete.EntityFramework;

namespace BanFramework.DataAccess.Tests.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(504, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p => p.Color == "Silver");

            Assert.AreEqual(43, result.Count);
        }
    }
}
