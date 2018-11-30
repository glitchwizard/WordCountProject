using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program_old
    {
        //public static void Main(string[] args)
        public void OldMain()
        {
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Hello, please input a word to find in a sentance: ");
            string userInputWord = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Thank you, please input a sentance to count how many times this word appears: ");

            string userInputSentance = Console.ReadLine();

            WordCount newWordToFind = new WordCount(userInputWord, userInputSentance);

            Console.WriteLine("");
            Console.WriteLine(newWordToFind.wordCount());

            Console.WriteLine("");
        }
    }
}