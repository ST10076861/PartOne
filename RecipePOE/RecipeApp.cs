using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipePOE
{
    internal class RecipeApp
    {
        public String nameOfRecipe;

        public String[] nameOfIng;
        public String[] description;
        public String[] unitOfmeasurement;

        public  int[] numOfIng;
        public  int[] quantityOfIng;
        public  int[] numbOfSteps;
        public  int scale;

        public string NameOfIngridients { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string Description { get; set; }

        public int QuantityOfIngridients { get; set; }
        public int NumberOfIngridients { get; set; }
        public int numberOfSteps { get; set; }


        public void storedRecipe()
        {
            Console.WriteLine("Enter the name of the recipe ");
            nameOfRecipe = Console.ReadLine();

            for (int i = 0; i<0; i++)
            {
                
                Console.WriteLine("Please enter the number of ingridients: ");
                numOfIng[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the name of the ingridient: ");
                nameOfIng[i] = Console.ReadLine();

                Console.WriteLine("Please enter the quantity of the ingridient: ");
                quantityOfIng[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter unit of measurement: ");
                unitOfmeasurement[i] = Console.ReadLine();

                Console.WriteLine("Please enter the number of steps: ");
                numbOfSteps[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Recipe stored successfully!");

        }
        public void stepsDescription()
        {
            for (int b = 0; b < numbOfSteps.Length; b++)
            {
                Console.WriteLine("Please add description for the steps");
                description[b] = Console.ReadLine();
            }
        }

        public void dispaly()
        {

            for (int i = 0; i < nameOfIng.Length; i++)
            {
                Console.WriteLine("the full recipe is: "+ nameOfRecipe +"\n" +
                    numOfIng[i] + "\n" + nameOfIng[i] + "\n" + quantityOfIng[i] +"\n"+ unitOfmeasurement[i]);
            }

        }
        public void scaleMeasurement()
        {
            Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());

            if (factor == 0.5)
            {
                for(int i = 0; i < quantityOfIng.Length; i++)
                {
                    quantityOfIng[i] *= 0.5;
                }
            }

            else if (factor == 2)
            {
                for(int i = 0;i < quantityOfIng.Length; i++)
                {
                    quantityOfIng[i] *= 2;
                }
            }

            else if (factor == 3)
            {
                for(int i = 0; i < quantityOfIng.Length; i++)
                {
                    quantityOfIng[i] *= 3;
                }
            }

            Console.WriteLine("quantity of ingridients has been scaled.");

        }

        public void resetQuantities()
        {
            for (int i = 0; i < quantityOfIng.Length; i++)
            {
                quantityOfIng[i] = default;
            }

        }
        public void clearData()
        {
            Array.Clear(numOfIng, 0, numOfIng.Length);

            Array.Clear(numbOfSteps,0,numbOfSteps.Length);

            Array.Clear(nameOfIng, 0, nameOfIng.Length);

            Array.Clear(quantityOfIng,0,quantityOfIng.Length);

            Array.Clear(description, 0, description.Length);

            Console.WriteLine("The stored recipe has been deleted.");
        }
        
    }
}
