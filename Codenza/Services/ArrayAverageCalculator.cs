using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenza.Services
{
    class ArrayAverageCalculator
    {
        public static void GetArrayAverage()
        {
            Console.WriteLine("\nGet Average from array of numbers \n");
            Console.WriteLine("How many numbers would you like to compute for?");
            string numberOfItemsString = Console.ReadLine();

            int numberOfItems;

            if(int.TryParse(numberOfItemsString, out numberOfItems))
            {
                Console.WriteLine(numberOfItems);

                int[] userNumbers = new int[numberOfItems];

                Console.WriteLine("Please enter your numbers");
                for(int i = 0; i < numberOfItems; i++)
                {
                    if(int.TryParse(Console.ReadLine(), out userNumbers[i]));
                }

                int sum = 0;
                for(int i = 0; i < numberOfItems; i++)
                {
                    sum = sum + userNumbers[i];
                }

                int average = sum / numberOfItems;
                Console.WriteLine($"Average = {average}");
            }
            else
            {
                Console.WriteLine("Please ensure you entered a valid number");
            }
        }
    }
}
