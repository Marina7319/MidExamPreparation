using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonCount = 0;
            string input = Console.ReadLine();
            while (input != "End of battle")
            {
                int distance = int.Parse(input);
                if (distance <= energy)
                {
                    energy -= distance;
                    wonCount++;
                    if (wonCount % 3 == 0)
                    {
                        energy = energy + wonCount;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonCount} won battles and {energy} energy");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonCount}. Energy left: {energy}");
            }
        }
    }
}
