using System;

namespace searchingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Search strings. Contains, IndexOf, and how C# string indexed as arrays
            string songLyrics = "You say goodbye, and I say hello";

            Console.WriteLine(songLyrics.Contains("goodbye"));

            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
        }
    }
}
