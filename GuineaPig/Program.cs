using System;

namespace GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityFoodInKilograms = double.Parse(Console.ReadLine()) * 1000;
            double quantityHayInKilograms = double.Parse(Console.ReadLine()) * 1000;
            double quantityCoverInKilograms = double.Parse(Console.ReadLine()) * 1000;
            double guineaWightInKilograms = double.Parse(Console.ReadLine()) * 1000;
            double coverForDay = guineaWightInKilograms * 1 / 3;
            for (int currentDay = 1; currentDay <= 30; currentDay++)
            {
                quantityFoodInKilograms -= 300;
                if (currentDay % 2 == 0)
                {

                    double hay = quantityFoodInKilograms * 0.05;
                    quantityHayInKilograms -= hay;
                    if (quantityHayInKilograms <= 0)
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        break;
                    }
                }
                if (currentDay % 3 == 0)
                {
                    quantityCoverInKilograms -= coverForDay;
                    if (quantityCoverInKilograms <= 0)
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        break;
                    }
                }
                if (quantityFoodInKilograms <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }
            if (quantityHayInKilograms > 0 && quantityCoverInKilograms > 0 && quantityFoodInKilograms > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFoodInKilograms / 1000:f2}, Hay: {quantityHayInKilograms / 1000:f2}, Cover: {quantityCoverInKilograms / 1000:f2}.");
            }
        }
    }
}
