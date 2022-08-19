using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            int expectedPlunder = int.Parse(Console.ReadLine());
            double plunder = 0;
            double thirdDayPlunder = dailyPlunder * 0.5;
            int daysCount = 0;
            for (int i = 1; i <= daysPlunder; i++)
            {
                daysCount++;
                plunder += dailyPlunder;
                if (daysCount % 3 == 0)
                {
                    plunder += thirdDayPlunder;
                }
                if (daysCount % 5 == 0)
                {
                    plunder *= 0.7;
                }
            }
            if (expectedPlunder <= plunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {((plunder / expectedPlunder) * 100):f2}% of the plunder.");
            }
        }
    }
}
