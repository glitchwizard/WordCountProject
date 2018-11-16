using System;

namespace WordCounter.Models {
    public class CountBL {
        private string _word;
        private string _sentance;

        public CountBL () {

        }

        public CountBL (string word) {
            _word = word;
        }

        public CountBL (string word, string sentance) {
            _word = word;
            _sentance = sentance;
        }

        public string GetWord () {
            return _word;
        }

        public string GetSentance() {
            return _sentance;
        }

        public string wordCount(string wordToFind, string sentanceToCheck) { 
            Console.WriteLine("This is wordToFind: {0}", wordToFind);
            Console.WriteLine("This is sentanceToCheck: {0}", sentanceToCheck);

            wordToFind = wordToFind.ToUpper();
            sentanceToCheck = sentanceToCheck.ToUpper();
            Console.WriteLine("This is wordToFind after ToUpper: {0}", wordToFind);
            Console.WriteLine("This is sentanceToCheck after ToUpper: {0}", sentanceToCheck);

            string[] sentanceArray = sentanceToCheck.Split(' ');
            foreach (var i in sentanceArray) {
                Console.WriteLine("This is an item in sentanceArray: {0}", i); 
            }
            

            return "wordCount has ended";
        }

    }
}