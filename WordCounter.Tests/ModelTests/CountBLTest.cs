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
            CountBL testCountBL = new CountBL ("Cathedral", "Hey, there's a good looking Cathedral");
            string testWord = "Cathedral";
            string testSentance = "Hey, there's a good looking Cathedral";

            Assert.AreEqual (testWord, testCountBL.GetWord ());
            Assert.AreEqual (testSentance, testCountBL.GetSentance ());
        }

        [TestMethod]
        public void wordCountIsRunning_ExecutionOfMethod_String () {
            CountBL testCountBL = new CountBL ("Cathedral", "Hey, there's a good looking Cathedral");

            Assert.AreEqual ("Your word cathedral was found 1 times in the sentance 'Hey, there's a good looking Cathedral'", testCountBL.wordCount());
        }

        [TestMethod]
        public void FindOneSingleLetter_FindASingleLetter_String () {
            string word = "i";
            string sentance = "i";
            CountBL testCountBL = new CountBL (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 1 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCountBL.wordCount());
        }

        [TestMethod]
        public void FindOneWordInSentance_FindASingleWordMultipleTimes_String () {
            string word = "I";
            string sentance = "Hello, I am cool, I think so at least.";
            CountBL testCountBL = new CountBL (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 2 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCountBL.wordCount());
        }
        [TestMethod]
        public void AccountForPunctuationSingleWord_IncludeWordsThatMayHavePunctuation_String () {
            string word = "Cool";
            string sentance = "Cool!";
            CountBL testCountBL = new CountBL (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 1 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCountBL.wordCount());
        }

        [TestMethod]
        public void AccountForPunctuationInSentance_IncludeWordsThatMayHavePunctuation_String () {
            string word = "Cool";
            string sentance = "Cool! This is so cool, don't you think it's cool?";
            CountBL testCountBL = new CountBL (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 3 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCountBL.wordCount());
            
        }
        [TestMethod]
        public void SmallerWordwithinAword_ExcludeSmallerWordsWithinWords_String () {
            string word = "cat";
            string sentance = "cathedral";
            CountBL testCountBL = new CountBL (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 0 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCountBL.wordCount());
            
        }
        [TestMethod]
        public void wordOneCharSmallerThanWhatsBeingChecked_NoWordCountAdded_String () {
            string word = "rat";
            string sentance = "rate";
            CountBL testCountBL = new CountBL (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 0 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCountBL.wordCount());
            
        }
                [TestMethod]
        public void wordHasMultiplePunctuationMarksAtEnd_CountsWord_String () {
            string word = "Cool";
            string sentance = "Cool!!";
            CountBL testCountBL = new CountBL (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 1 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCountBL.wordCount());
            
        }
    }
}