using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = Console.ReadLine().Split(separator: '!').ToList(); ;
            string currentWord = Console.ReadLine();
            List<string> shoppingGoals = new List<string>();
            while (currentWord != "Go Shopping!")
            {
                string[] itemsList = currentWord.Split(separator: ' ');
                switch (itemsList[0])
                {
                    case "Urgent":
                        if (!shoppingList.Contains(itemsList[1]))
                        {
                            shoppingGoals.Insert(0, itemsList[1]);
                        }
                        break;
                    case "Unnecessary":
                        shoppingList.Remove(itemsList[1]);
                        break;
                    case "Correct":
                        if (shoppingList.Contains(itemsList[1]))
                        {
                            int index = shoppingList.IndexOf(itemsList[1]);
                            shoppingList.Remove(itemsList[1]);
                            shoppingList.Insert(index, itemsList[2]);
                        }
                        break;
                    case "Rearrange":
                        if (shoppingList.Contains(itemsList[1]))
                        {
                            shoppingList.Remove(itemsList[1]);
                            shoppingList.Add(itemsList[1]);
                        }
                        break;
                }
                currentWord = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
