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

        public string wordCount() { 

            string wordToFind = this._word;
            string sentanceToCheck = this._sentance;

            string wordToFindUpper = wordToFind.ToUpper();
            string sentanceToCheckUpper = sentanceToCheck.ToUpper();

            string[] sentanceArray = sentanceToCheckUpper.Split(' ');
            int wordCount = 0;

            foreach (var i in sentanceArray) { 
                if (i == wordToFindUpper) {
                    wordCount++;
                } 
                else if ( i != wordToFindUpper) {
                    char[] charArray = i.toCharArray();
                    char c = 'A';
                    foreach (var j in charArray)
                    while (c <= 'z') {
                        if (j == i)
                        c++;
                    }
                }
            }

            string output = "Your word " + wordToFind + " was found " + wordCount + " times in the sentance '" + sentanceToCheck + "'";
            
            return output;
        }
    }
}