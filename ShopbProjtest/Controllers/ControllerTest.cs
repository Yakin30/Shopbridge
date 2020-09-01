using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopbProj.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Mvc;

namespace ShopbProj.Controllers.Tests
{
    [TestClass()]
    public class ControllerTest
    {
        [TestMethod()]
        public void IndexTest()
        {
            ShopbridgesController controller = new ShopbridgesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod()]
        public void CreateTest()
        {

            ShopbridgesController controller = new ShopbridgesController();

            ViewResult result = controller.Create() as ViewResult;

            Assert.IsNotNull(result);

        }

        [TestMethod()]
        public void EditTest()
        {
            ShopbridgesController controller = new ShopbridgesController();
            
            ViewResult result = controller.Edit(1) as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}