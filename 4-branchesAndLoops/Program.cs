﻿using System;

namespace branches
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            // while loop
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello world! The counter is {counter}");
                counter++;
            }

            // do ... while loop
            do
            {
                Console.WriteLine($"Hello world! The counter is {counter}");
                counter++;

            } while (counter < 10);

            // for loop
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello world! The counter is {counter}");
            }
        }
    }
}
