using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] currentStateOfTheLine = Console.ReadLine().Split(separator: " ").Select(int.Parse).ToArray();
            int maxSits = currentStateOfTheLine.Length * 4;
            int sitsCount = 0;
            int peopleSitting = 0;
            for (int i = 0; i < currentStateOfTheLine.Length; i++)
            {
                peopleSitting += currentStateOfTheLine[i];
                for (int j = 0; j <= 4; j++)
                {
                    if (currentStateOfTheLine[i] == 4)
                    {
                        break;
                    }
                    currentStateOfTheLine[i]++;
                    sitsCount++;
                    if (sitsCount >= waitingPeople)
                    {
                        break;
                    }
                }
                if (sitsCount >= waitingPeople)
                {
                    break;
                }
            }
            int left = peopleSitting + sitsCount;
            if (maxSits == left && waitingPeople == 0)
            {
            }
            if (sitsCount < waitingPeople)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople - sitsCount} people in a queue!");
            }
            if (maxSits > left)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            for (int j = 0; j < currentStateOfTheLine.Length; j++)
            {
                Console.Write(currentStateOfTheLine[j] + " ");
            }
        }
    }
}

