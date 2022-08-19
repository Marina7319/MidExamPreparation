using System;
using System.Linq;
using System.Collections.Generic;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(separator: " ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string inputTextLine = Console.ReadLine();
            int shootsCount = 0;
            int[] arr = new int[input.Length];
            List<int> numbers = new List<int>();
            while (inputTextLine != "End")
            {
                int num = int.Parse(inputTextLine);
                if (num < input.Length)
                {
                    shootsCount++;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (num != i)
                        {
                            if (input[num] < input[i])
                            {
                                input[i] -= input[num];
                      
                            }
                            else
                            {
                                input[i] += input[num];

                            }
                        }                    
                    }
                }
                inputTextLine = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shootsCount} -> ");
            for (int j = 0; j < input.Length; j++)
            {
                Console.Write(input[j] + " ");
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
