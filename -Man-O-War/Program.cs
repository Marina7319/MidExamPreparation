using System;
using System.Linq;
using System.Collections.Generic;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            var statusOfThePirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            var statusOfTheWarship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> maximumHealthCapacity = new List<int>();
            maximumHealthCapacity.AddRange(statusOfThePirateShip);
            int maximumHealth = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "Retire")
            {
                var commands = input.Split(" ").ToList();
                string tokens = commands[0];
                switch (tokens)
                {
                    case "Fire":
                        int index = int.Parse(commands[1]); ;
                        if (index <= statusOfTheWarship.Count)
                        {
                            statusOfTheWarship[index] = statusOfTheWarship[index] - int.Parse(commands[2]);
                            if (statusOfTheWarship[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                break;
                            }
                        }
                        break;
                    case "Defend":
                        int startNum = int.Parse(commands[1]);
                        int endNum = int.Parse(commands[2]);
                        if (endNum <= statusOfThePirateShip.Count)
                        {
                            for (int x = startNum; x <= endNum; x++)
                            {
                                statusOfThePirateShip[x] = statusOfThePirateShip[x] - int.Parse(commands[3]);
                                if (statusOfThePirateShip[x] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    break;
                                }
                            }
                        }
                        break;
                    case "Repair":
                        int indexRepair = int.Parse(commands[1]); ;
                        if (indexRepair <= statusOfThePirateShip.Count)
                        {
                            statusOfThePirateShip[indexRepair] = statusOfThePirateShip[indexRepair] + int.Parse(commands[2]);
                            if (statusOfThePirateShip[indexRepair] >= maximumHealth)
                            {
                                statusOfThePirateShip[indexRepair] = maximumHealth;
                            }
                        }
                        break;
                    case "Status":
                        int repairShipsCount = 0;
                        for (int y = 0; y < statusOfThePirateShip.Count; y++)
                        {
                            if (maximumHealth * 0.2 > statusOfThePirateShip[y])
                            {
                                repairShipsCount++;
                            }
                        }
                        Console.WriteLine($"{repairShipsCount} sections need repair.");
                        break;
                }
                input = Console.ReadLine();
            }
            for (int z = 0; z < statusOfThePirateShip.Count; z++)
            {
                if (statusOfThePirateShip[z] > 0)
                {
                    Console.WriteLine($"Pirate ship status: {statusOfThePirateShip.Sum()}");
                    Console.WriteLine($"Warship status: {statusOfTheWarship.Sum()}");
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
