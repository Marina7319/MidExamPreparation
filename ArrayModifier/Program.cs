using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();


                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split();
                string actions = tokens[0];
                switch (actions)
                {
                    case "swap":
                        Swap(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                        break;
                    case "multiply":
                        Multiply(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                        break;
                    case "decrease":
                        Decrease(numbers);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Multiply(int firstIndex, int secondIndex, List<int> numbers)
        {
            numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
        }
        private static void Decrease(List<int> numbers)
        {
            for (int number = 0; number < numbers.Count; number++)
            {
                numbers[number] = numbers[number] - 1;
            }
        }

        private static void Swap(int firstIndex, int secondIndex, List<int> numbers)
        {
            int firstNumber = numbers[firstIndex];
            int secondNumber = numbers[firstIndex];
            int temp = firstNumber;
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}
