using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maths and Intgers
            /*
            int a = 13;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c);
             */

            // Number and Integer Precision
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            // write code that calculates the area of a circle whose radius is 2.50 centimeters.
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
