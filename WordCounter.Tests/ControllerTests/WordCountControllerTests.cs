using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using WordCounter.Controllers;


namespace WordCounter.Tests
{
    [TestClass]
    class WordCountControllerTests
    {

        [TestMethod]
        public void Index_HasCorrectAction_WordcounterIndex()
        {
            //Arrange
            WordCountController controller = new WordCountController();
            ViewResult viewResult = controller.Index() as ViewResult;

            //Act
            var result = viewResult.ViewName;

            //Assert
            Assert.AreEqual(result, "Index");
        }
    }
}
