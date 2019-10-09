using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic of strings
            string firstFriend = "Vincent";
            string secondFriend = "Anita";
            string greeting = "        Hello world!      ";
            string sayHello = "Hello World!";

            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
            
            // length of a string
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            // triming white spaces in string
            Console.WriteLine(greeting);
            Console.WriteLine(greeting.TrimStart());
            Console.WriteLine(greeting.TrimEnd());
            Console.WriteLine(greeting.Trim());

            // replace method in strings
            sayHello = sayHello.Replace("World!", "9ja!");
            Console.WriteLine(sayHello);

            // All CAPS and all lower case methods
            Console.WriteLine(firstFriend.ToUpper());
            Console.WriteLine(firstFriend.ToLower());

        }
    }
}
