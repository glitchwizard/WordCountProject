using System;
using System.Collections.Generic;

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

            foreach (string wordBeingChecked in sentanceArray) { 
                if (wordBeingChecked == wordToFindUpper) {
                    wordCount++;
                } 
                else if ( wordBeingChecked != wordToFindUpper) {

                    char[] charArray = wordBeingChecked.ToCharArray();

                    List<char> wordTurnedToListWithoutPunctuation = new List<char>{};

                    char lastChar = wordBeingChecked[wordBeingChecked.Length-1];


                    foreach (char j in charArray) {
                        char c = 'A';
                        char d = 'a';
                        System.Console.WriteLine("This is the current Char: " + j);

                        while (c <= 'Z' && d <= 'z') {
                            if (j == c || j == d) {
                                wordTurnedToListWithoutPunctuation.Add(j);
                                string wordWithoutPunctuationToAssembled = string.Join("", wordTurnedToListWithoutPunctuation.ToArray());

                                if (wordWithoutPunctuationToAssembled == wordToFindUpper && wordBeingChecked.Length-1 == wordToFindUpper.Length)
                                {
                                    if (Char.IsPunctuation(lastChar) == true) {
                                        wordCount++;
                                    }
                                    
                                } 
                            } 
                            c++;
                            d++;
                        }
                    }
                }
            }

            string output = "Your word " + wordToFind.ToLower() + " was found " + wordCount + " times in the sentance '" + sentanceToCheck + "'";
            // ↑ ↑ ↓ ↓ ← → ← → B A
            return output;
        }
    }
}