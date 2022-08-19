using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceParts = 0;
            string input = Console.ReadLine();
            double pricesWithoutTaxes = 0;
            while (input != "regular" && input != "special")
            {
                priceParts = double.Parse(input);
                if (priceParts <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    pricesWithoutTaxes += priceParts;
                }
                input = Console.ReadLine();
            }
            double taxes = pricesWithoutTaxes * 0.2;
            double totalPrice = pricesWithoutTaxes + taxes;
            if (input == "special")
            {
                totalPrice = totalPrice - totalPrice * 0.1;
            }
            if (pricesWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {pricesWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
