using System;
using System.Linq;
using System.Collections.Generic;
namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] tokens = command.Split();
                string action = tokens[0];
                switch (action)
                {
                    case "Shoot":
                        Shoot(int.Parse(tokens[1]), int.Parse(tokens[2]), target);
                        break;
                    case "Add":
                        Add(int.Parse(tokens[1]), int.Parse(tokens[2]), target);
                        break;
                    case "Strike":
                        Strike(int.Parse(tokens[1]), int.Parse(tokens[2]), target);
                        break;
                }
            }
            Console.WriteLine(string.Join("|", target));
        }
        static void Strike(int index, int radius, List<int> target)
        {
            if (index < 0 || index > target.Count - 1 || index - radius < 0 || index + radius > target.Count - 1)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            target.RemoveRange(index - radius, radius * 2 + 1);
        }
        static void Add(int index, int value, List<int> target)
        {
            if (index < 0 || index > target.Count - 1)
            {
                Console.WriteLine("Invalid placement!");
                return;
            }
            target.Insert(index, value);
        }
        static void Shoot(int index, int power, List<int> target)
        {
            if (index < 0 || index > target.Count - 1)
            {
                return;
            }
            target[index] -= power;
            if (target[index] <= 0)
            {
                target.RemoveAt(index);
            }
        }
    }
}
