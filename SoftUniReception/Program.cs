using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEfficiency = int.Parse(Console.ReadLine());
            int secondEfficiency = int.Parse(Console.ReadLine());
            int thirdEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int sumStudentsForHour = firstEfficiency + secondEfficiency + thirdEfficiency;
            double hoursCount = 0;
            while (studentsCount > 0)
            {
                hoursCount++;
                if (hoursCount % 4 == 0)
                {
                    studentsCount -= 0;
                }
                else
                {
                    studentsCount -= sumStudentsForHour;
                }
            }
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
