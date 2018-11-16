using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {
    [TestClass]
    public class CountBLTest {
        [TestMethod]
        public void DoesClassInstantiate_InstantitionSuccessful_NewObj () {
            CountBL testCountBL = new CountBL ();

            Assert.AreEqual (typeof (CountBL), testCountBL.GetType ());
        }

        [TestMethod]
        public void IsInputWord_CapturedAsData_String () {
            CountBL testCountBL = new CountBL ("Cathedral");
            string testArgument = "Cathedral";

            Assert.AreEqual (testArgument, testCountBL.GetWord ());
        }

        [TestMethod]
        public void IsCapturingWordAndSentance_CapturedAsData_String () {
            CountBL testCountBL = new CountBL ("Cathedral", "Hey there's a good looking Cathedral");
            string testWord = "Cathedral";
            string testSentance = "Hey there's a good looking Cathedral";

            Assert.AreEqual (testWord, testCountBL.GetWord ());
            Assert.AreEqual (testSentance, testCountBL.GetSentance ());
        }

        [TestMethod]
        public void wordCountIsRunning_ExecutionOfMethod_String () {
            CountBL testCountBL = new CountBL ("Cathedral", "Hey there's a good looking Cathedral");

            Assert.AreEqual ("wordCount has ended", testCountBL.wordCount (testCountBL.GetWord (), testCountBL.GetSentance ()));
        }
    }
}