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

            foreach (string i in sentanceArray) { 
                if (i == wordToFindUpper) {
                    wordCount++;
                } 
                else if ( i != wordToFindUpper) {
                    char[] charArray = i.ToCharArray();
                    List<char> wordListWithoutPunctuation = new List<char>{};

                    foreach (char j in charArray) {
                        char c = 'A';
                        char d = 'a';
                        while (c <= 'Z' && d <= 'z') {
                            if (j == c || j == d) {
                                System.Console.WriteLine("j: {0} || i: {1}", j, i);
                                wordListWithoutPunctuation.Add(j);
                                string wordWithoutPunctuationToAssembled = string.Join("", wordListWithoutPunctuation.ToArray());
                                System.Console.WriteLine("This is the word without punctuation: " + wordWithoutPunctuationToAssembled);
                                if (wordWithoutPunctuationToAssembled == i && wordWithoutPunctuationToAssembled.Length == i.Length){
                                    wordCount++;
                                }

                            } 

                            c++;
                            d++;
                        }
                    }
                }
            }

            string output = "Your word " + wordToFind + " was found " + wordCount + " times in the sentance '" + sentanceToCheck + "'";
            
            return output;
        }
    }
}