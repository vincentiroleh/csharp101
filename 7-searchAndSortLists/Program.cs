using System;
using System.Collections.Generic;

namespace searchAndSortLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Iroleh", "Anita", "Marble", "Trust", "Uche" };

            names.Add("Paradise");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            var index = names.IndexOf("Iroleh");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
