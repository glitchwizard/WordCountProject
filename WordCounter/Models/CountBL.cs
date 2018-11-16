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
                    List<char> wordListWithoutPunctuation = new List<char>{};
                    int letterIndex = 0;
                    System.Console.WriteLine("EARLY: This is the count of the wordListWithoutPunctuation: "+ wordListWithoutPunctuation.Count);

                    foreach (char j in charArray) {
                        char c = 'A';
                        char d = 'a';

                        while (c <= 'Z' && d <= 'z') {
                            if (j == c || j == d) {
                                wordListWithoutPunctuation.Add(j);
                                string wordWithoutPunctuationToAssembled = string.Join("", wordListWithoutPunctuation.ToArray());
                                
                                System.Console.WriteLine("");
                                System.Console.WriteLine("wordWithoughPunctuationToAssembled: " + wordWithoutPunctuationToAssembled);
                                System.Console.WriteLine("wordBeingChecked: " + wordBeingChecked);
                                System.Console.WriteLine("wordToFindUpper: " + wordToFindUpper);
                                System.Console.WriteLine("This is the count of the wordListWithoutPunctuation: "+ wordListWithoutPunctuation.Count);


                                if (wordWithoutPunctuationToAssembled == wordToFindUpper && wordBeingChecked.Length-1 == wordToFindUpper.Length)
                                {
                                    wordCount++;
                                } 
                                // if (wordWithoutPunctuationToAssembled == wordToFindUpper && wordBeingChecked.Length-1 == wordToFindUpper.Length){
                                //     wordCount++;
                                // } 
                            } 
                            c++;
                            d++;
                        }
                        letterIndex++;
                    }
                }
            }

            string output = "Your word " + wordToFind.ToLower() + " was found " + wordCount + " times in the sentance '" + sentanceToCheck + "'";
            
            return output;
        }
    }
}