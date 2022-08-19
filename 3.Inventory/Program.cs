using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                var command = input.Split(" - ").ToList();
                string tokens = command[0];
                switch (tokens)
                {
                    case "Collect":
                        if (!items.Contains(command[1]))
                        {
                            items.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        if (items.Contains(command[1]))
                        {
                            items.Remove(command[1]);
                        }
                        break;
                    case "Combine Items":
                        string[] itemOneTwo = command[1].Split(separator: ":");
                        int index = 0;
                        if (items.Contains(itemOneTwo[0]))
                        {
                            index = items.IndexOf(itemOneTwo[0]);
                        }
                        items.Insert(index + 1, itemOneTwo[1]);
                        break;
                    case "Renew":
                        if (items.Contains(command[1]))
                        {
                            items.Remove(command[1]);
                            items.Add(command[1]);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
