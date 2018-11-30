using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using WordCounter.Controllers;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_ReturnsAViewResult_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));

        }

        [Test]
    }
}
