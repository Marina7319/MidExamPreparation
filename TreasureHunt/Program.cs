using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split("|").ToList();
            List<string> tresureSteal = new List<string>();
            string input = Console.ReadLine();
            while (input != "Yohoho!")
            {
                var commands = input.Split(" ").ToArray();
                string tokens = commands[0];
                switch (tokens)
                {
                    case "Loot":
                        int j = 1;
                        while (commands.Length > j)
                        {
                            if (!treasure.Contains(commands[j]))
                            {
                                treasure.Insert(0, commands[j]);
                            }
                            j++;
                        }
                        break;
                    case "Drop":
                        int namesCount = int.Parse(commands[1]);
                        if (treasure.Count >= namesCount && namesCount >= 0)
                        {
                            string elementAtPossition = treasure[namesCount];
                            treasure.RemoveAt(namesCount);
                            treasure.Add(elementAtPossition);
                        }
                        break;
                    case "Steal":
                        int steal = int.Parse(commands[1]);
                        int sumRemove = treasure.Count - steal;
                        for (int stealTreasure = sumRemove; stealTreasure < treasure.Count; stealTreasure++)
                        {
                            tresureSteal.Add(treasure[stealTreasure]);
                        }
                        treasure.RemoveRange(sumRemove, steal);
                        Console.WriteLine(string.Join(", ", tresureSteal));
                        break;
                }
                input = Console.ReadLine();
            }
            double sum = 0;
            foreach (string nums in treasure)
            {
                sum += nums.Length;
            }
            if (treasure.Count > 0)
            {
                double avgTresureGain = sum / treasure.Count;
                Console.WriteLine($"Average treasure gain: {avgTresureGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
