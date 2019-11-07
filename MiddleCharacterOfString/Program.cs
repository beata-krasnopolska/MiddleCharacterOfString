using System;

namespace MiddleCharacterOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes a string (single word) and returns the middle character(s). If the word's length is odd, return the middle character. If the word's length is even, return the middle two characters.");

            Console.WriteLine("Enter a word:");
            string userWord = Console.ReadLine();

            var middleFinder = new MiddleFinder();
            var middleLetters = middleFinder.FindMiddle(userWord);

            Console.WriteLine(middleLetters);

            Console.ReadKey();
        }
    }
}
