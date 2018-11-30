using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {
    [TestClass]
    public class CounterTest {
        [TestMethod]
        public void DoesClassInstantiate_InstantitionSuccessful_NewObj () {
            Counter testCounter = new Counter ();

            Assert.AreEqual (typeof (Counter), testCounter.GetType ());
        }

        [TestMethod]
        public void IsInputWord_CapturedAsData_String () {
            Counter testCounter = new Counter ("Cathedral");
            string testArgument = "Cathedral";

            Assert.AreEqual (testArgument, testCounter.GetWord ());
        }

        [TestMethod]
        public void IsCapturingWordAndSentance_CapturedAsData_String () {
            Counter testCounter = new Counter ("Cathedral", "Hey, there's a good looking Cathedral");
            string testWord = "Cathedral";
            string testSentance = "Hey, there's a good looking Cathedral";

            Assert.AreEqual (testWord, testCounter.GetWord ());
            Assert.AreEqual (testSentance, testCounter.GetSentance ());
        }

        [TestMethod]
        public void wordCountIsRunning_ExecutionOfMethod_String () {
            Counter testCounter = new Counter ("Cathedral", "Hey, there's a good looking Cathedral");

            Assert.AreEqual ("Your word cathedral was found 1 times in the sentance 'Hey, there's a good looking Cathedral'", testCounter.wordCount());
        }

        [TestMethod]
        public void FindOneSingleLetter_FindASingleLetter_String () {
            string word = "i";
            string sentance = "i";
            Counter testCounter = new Counter (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 1 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCounter.wordCount());
        }

        [TestMethod]
        public void FindOneWordInSentance_FindASingleWordMultipleTimes_String () {
            string word = "I";
            string sentance = "Hello, I am cool, I think so at least.";
            Counter testCounter = new Counter (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 2 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCounter.wordCount());
        }
        [TestMethod]
        public void AccountForPunctuationSingleWord_IncludeWordsThatMayHavePunctuation_String () {
            string word = "Cool";
            string sentance = "Cool!";
            Counter testCounter = new Counter (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 1 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCounter.wordCount());
        }

        [TestMethod]
        public void AccountForPunctuationInSentance_IncludeWordsThatMayHavePunctuation_String () {
            string word = "Cool";
            string sentance = "Cool! This is so cool, don't you think it's cool?";
            Counter testCounter = new Counter (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 3 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCounter.wordCount());
            
        }
        [TestMethod]
        public void SmallerWordwithinAword_ExcludeSmallerWordsWithinWords_String () {
            string word = "cat";
            string sentance = "cathedral";
            Counter testCounter = new Counter (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 0 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCounter.wordCount());
            
        }
        [TestMethod]
        public void wordOneCharSmallerThanWhatsBeingChecked_NoWordCountAdded_String () {
            string word = "rat";
            string sentance = "rate";
            Counter testCounter = new Counter (word, sentance);

            string testAnswer = "Your word " + word.ToLower() + " was found " + 0 + " times in the sentance '" + sentance + "'";

            Assert.AreEqual (testAnswer, testCounter.wordCount());
            
        }
    }
}