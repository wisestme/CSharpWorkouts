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
                    if (int.TryParse(Console.ReadLine(), out userNumbers[i]))
                    { }
                    else
                        Console.WriteLine("Please check your input");
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

        public static void HowManyOne()
        {
            Console.WriteLine("\nCount the number of 1s \n");
            Console.WriteLine("How many numbers would you like to add?");

            string numberOfElementsString = Console.ReadLine();

            int numberOfElements;

            if(int.TryParse(numberOfElementsString, out numberOfElements))
            {
                int[] selectedNumbers = new int[numberOfElements];
                Console.WriteLine($"Enter {numberOfElements} numbers");

                for (int i = 0; i < numberOfElements; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out selectedNumbers[i]))
                    { }
                    else
                        Console.WriteLine("Ensure your input is valid");
                }

                int counter = 0;
                for(int i = 0; i < numberOfElements; i++)
                {
                    if(selectedNumbers[i] == 1)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"There are {counter} 1s in all the numbers you entered");
            }
        }
    }
}
