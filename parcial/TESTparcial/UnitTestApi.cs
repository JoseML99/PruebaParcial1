using System;
using APIparcial.Models;
using APIparcial.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TESTparcial
{
    [TestClass]
    public class UnitTestApi
    {
        [TestMethod]
        public void TestMethodGet()
        {
            Product producto = new Product();
            ProductsController control = new ProductsController();

            var resp = control.GetProduct(1);
        }
    }
}
