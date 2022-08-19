using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double sum = 0;
            double maxBonus = double.MinValue;
            double studentAttendances = 0;
            double totalBonus = 0;
            int maxBonusPoints = lectures;
            for (int i = 0; i < students; i++)
            {
                double attendanceOfEachStudent = double.Parse(Console.ReadLine());
                totalBonus = attendanceOfEachStudent / maxBonusPoints * (bonus + 5);
                sum += totalBonus;
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    studentAttendances = attendanceOfEachStudent;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");
        }
    }
}
