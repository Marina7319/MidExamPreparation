using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(separator: " ").Select(int.Parse).ToList();
            if (numbers.Count <= 1)
            {
                Console.WriteLine("No");
                return;
            }
            double sum = numbers.Sum();
            double average = sum / numbers.Count;
            List<double> numbersTop5 = new List<double>();
            foreach (double nums in numbers)
            {
                if (nums > Math.Round(average))
                {
                    numbersTop5.Add(nums);
                }
            }
            double tmp = 0;
            for (int i = 0; i <= numbersTop5.Count; i++)
            {
                for (int j = i + 1; j < numbersTop5.Count; j++)
                {
                    if (numbersTop5[j] > numbersTop5[i])
                    {
                        tmp = numbersTop5[i];
                        numbersTop5[i] = numbersTop5[j];
                        numbersTop5[j] = tmp;
                    }
                }
            }
            List<double> result = new List<double>();
            if (numbersTop5.Count > 5)
            {
                for (int x = 0; x < 5; x++)
                {
                    result.Add(numbersTop5[x]);
                }
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbersTop5));
            }
        }
    }
}
