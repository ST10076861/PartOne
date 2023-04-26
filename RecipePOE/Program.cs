using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipePOE
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the recipe app :)");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Enter a new recipe");
            Console.WriteLine("2. View current recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear all data");
            Console.WriteLine("6. Exit");

            int menu = Convert.ToInt32(Console.ReadLine());

            RecipeApp app = new RecipeApp();

            switch (menu)
            {
             case 1:
             app.storedRecipe();
             break;

             case 2:
             app.dispaly();
             break;

             case 3:
             app.scaleMeasurement();
             break;

             case 4:
             app.resetQuantities();
             break;

             case 5:
             app.clearData();
             break;

             case 6:
             Console.WriteLine("Thank you for using our app!");
             Environment.Exit(6);
             break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    break;

            }

        }
    }
}
