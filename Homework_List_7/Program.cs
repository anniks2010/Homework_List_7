using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_List_7
{
    class Program
    {
        static void Main(string[] args)
        {

            string userAnswer;
            var shopingList = GetShoppingList();
            bool shopingListIsDone = false;

            while (shopingListIsDone != true)
            {
                Console.WriteLine("Would you like to add or remove items from the shopping list? If not, then say 'no'.");
                userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "add")
                {
                    Console.WriteLine("Enter item, what you would like to add:");
                    string newItem = Console.ReadLine();
                    shopingList.Add(newItem);
                }
                else if (userAnswer == "remove")
                {
                    Console.WriteLine("Enter item, what you would like to remove:");
                    string newItem = Console.ReadLine();
                    shopingList.Remove(newItem);
                }
                else if (userAnswer == "no")
                {
                    shopingListIsDone = true; 
                }
                else
                {
                    Console.WriteLine($"Please enter add, remove or no.");
                }

                Console.Clear();

                for (int i = 0; i < shopingList.Count; i++)
                {
                    Console.WriteLine($" item {i + 1}: {shopingList[i]}");
                }

               Console.WriteLine($"List is updated on {DateTime.Now}");

            }

            Console.ReadLine();

        }
        public static List<string> GetShoppingList()
        {

            Console.WriteLine("Please enter products what needs to be in shopping list:");
            string userInput = Console.ReadLine();

            Console.Clear();

            string[] shoppingItems = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> shoppingList = shoppingItems.ToList();

            for (int i = 0; i < shoppingItems.Length; i++)
            {

                Console.WriteLine($" item {i + 1}: {shoppingList[i]}");

            }

            var currentDate = DateTime.Now;
            Console.WriteLine($"List is updated on {currentDate}");
            return shoppingList;

        }
        

    }
}    

