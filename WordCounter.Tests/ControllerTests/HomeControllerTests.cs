using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using WordCounter.Controllers;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTests : IDisposable
    {
        public void Dispose()
        {
            //WordCount.ClearAll();
        }
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



        //Lina, do I need to test anything else if it's a splash page for Home index?

    }
    
    //Arrange

    //Act

    //Assert
}

