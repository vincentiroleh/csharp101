using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"Iroleh", "Anita", "Marble", "Trust", "Uche"};

            names.Add("Paradise");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            Console.WriteLine($"The list of names has {names.Count} people in it.");
        }
    }
}
