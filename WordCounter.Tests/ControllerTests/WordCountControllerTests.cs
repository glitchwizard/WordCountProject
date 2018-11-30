﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using WordCounter.Controllers;
using System;


namespace WordCounter.Tests
{
    [TestClass]
    public class WordCountControllerTests
    {
        // WORDCOUNT CONTROLLER INDEX TEST METHODS
        [TestMethod]
        [TestCategory("WordCountIndexAction")]
        public void Index_ReturnsAViewResult_True()
        {
            //Arrange
            WordCountController controller = new WordCountController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));

        }

        [TestMethod]
        [TestCategory("WordCountIndexAction")]
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

        [TestMethod]
        [TestCategory("WordCountIndexAction")]
        public void Index_HasCorrectModelType_WordCountObject()
        {
            //Arrange
            ViewResult indexView = new WordCountController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(WordCount));
        }

        // WORDCOUNT CONTROLLER NEW TEST METHODS
        [TestMethod]
        [TestCategory("WordCountNewAction")]
        public void New_ReturnsAViewResult_True()
        {
            //Arrange
            WordCountController controller = new WordCountController();

            //Act
            ActionResult newView = controller.New("Cool", "Cool!");

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        [TestCategory("WordCountNewAction")]
        public void New_ReturnsCorrectActionType_Index()
        {
            //Arrange
            WordCountController controller = new WordCountController();
            ViewResult viewResult = controller.New("Cool", "Cool!") as ViewResult;

            //Act
            string result = viewResult.ViewName;

            //Assert
            Assert.AreEqual(result, "Index");

        }

        [TestMethod]
        [TestCategory("WordCountNewAction")]
        public void New_HasCorrectModelType_WordCountObject()
        {
            //Arrange
            WordCountController controller = new WordCountController();
            ViewResult newView = controller.New("Cool", "Cool!") as ViewResult;

            //Act
            var result = controller.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(WordCount));
        }
       
        //Arrange

        //Act

        //Assert
    }
}
