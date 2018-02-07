using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NymityProject;
using NymityProject.Controllers;

namespace NymityProject.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Products()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Products() as ViewResult;

            // Assert
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.IsNotNull(result);
        }
    }
}
