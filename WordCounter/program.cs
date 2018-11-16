using System;
using WordCounter.Models;

namespace WordCounter {
    public class Program {
        public static void Main () {
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            Console.WriteLine("Hello, please input a word to find in a sentance: ");
            string userInputWord = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Thank you, please input a sentance to count how many times this word appears: ");
            string userInputSentance = Console.ReadLine();
            CountBL newWordToFind = new CountBL(userInputWord, userInputSentance);

            System.Console.WriteLine("");

            Console.WriteLine(newWordToFind.wordCount());

            System.Console.WriteLine("");
            System.Console.WriteLine("Thanks for playing, please press a key to end this program");
            Console.ReadKey();
        }
    }
}