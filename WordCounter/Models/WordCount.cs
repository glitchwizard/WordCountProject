using System;
using System.Collections.Generic;

namespace WordCounter.Models {

    public class WordCount {
        private string _word;
        private string _sentance;


        public WordCount () {

        }

        public WordCount (string word) {
            _word = word;
        }

        public WordCount (string word, string sentance) {
            _word = word;
            _sentance = sentance;
        }

        public string GetWord () {
            return _word;
        }

        public string GetSentance() {
            return _sentance;
        }

        //public static void ClearAll()
        //{
        //    _instances.Clear();
        //}

        public string wordCount() { 

            string wordToFind = this._word;
            string sentanceToCheck = this._sentance;

            string wordToFindUpper = wordToFind.ToUpper();
            string sentanceToCheckUpper = sentanceToCheck.ToUpper();

            string[] sentanceArray = sentanceToCheckUpper.Split(' ');
            int wordCount = 0;

            foreach (string wordBeingChecked in sentanceArray)
            {
                wordCount = BeginCheckingWords(wordToFindUpper, wordCount, wordBeingChecked);
            }

            string output = "Your word " + wordToFind.ToLower() + " was found " + wordCount + " times in the sentance '" + sentanceToCheck + "'";
            
            return output;
        }

        private static int BeginCheckingWords(string wordToFindUpper, int wordCount, string wordBeingChecked)
        {
            if (wordBeingChecked == wordToFindUpper)
            {
                wordCount++;
            }
            else if (wordBeingChecked != wordToFindUpper)
            {
                char[] charArray = wordBeingChecked.ToCharArray();
                List<char> wordListWithoutPunctuation = new List<char> { };
                char lastChar = wordBeingChecked[wordBeingChecked.Length - 1];

                foreach (char j in charArray)
                    wordCount = BeginCheckingLettersInCharArray(wordToFindUpper, wordCount, wordBeingChecked, wordListWithoutPunctuation, lastChar, j);
            }

            return wordCount;
        }

        private static int BeginCheckingLettersInCharArray(string wordToFindUpper, int wordCount, string wordBeingChecked, List<char> wordListWithoutPunctuation, char lastChar, char j)
        {
            {
                char c = 'A';
                char d = 'a';

                CheckIndividualLetterAgainstAlphabet(wordToFindUpper, ref wordCount, wordBeingChecked, wordListWithoutPunctuation, lastChar, j, ref c, ref d);
            }

            return wordCount;
        }

        private static void CheckIndividualLetterAgainstAlphabet(string wordToFindUpper, ref int wordCount, string wordBeingChecked, List<char> wordListWithoutPunctuation, char lastChar, char j, ref char c, ref char d)
        {
            while (c <= 'Z' && d <= 'z')
            {
                if (j == c || j == d)
                {
                    wordListWithoutPunctuation.Add(j);
                    string wordWithoutPunctuationToAssembled = string.Join("", wordListWithoutPunctuation.ToArray());

                    wordCount = CheckWordToFindAgainstWordBeingChecked(wordToFindUpper, wordCount, wordBeingChecked, lastChar, wordWithoutPunctuationToAssembled);
                }
                c++;
                d++;
            }
        }

        private static int CheckWordToFindAgainstWordBeingChecked(string wordToFindUpper, int wordCount, string wordBeingChecked, char lastChar, string wordWithoutPunctuationToAssembled)
        {
            if (wordWithoutPunctuationToAssembled == wordToFindUpper && wordBeingChecked.Length - 1 == wordToFindUpper.Length)
            {
                wordCount = LastCharIsPunctuation(wordCount, lastChar);

            }

            return wordCount;
        }

        private static int LastCharIsPunctuation(int wordCount, char lastChar)
        {
            if (Char.IsPunctuation(lastChar) == true)
            {
                wordCount++;
            }

            return wordCount;
        }
    }
}