using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Program to check if entered number is odd or even*/
namespace Codenza.Services
{
    class OddEven
    {
        public static void CheckOddEven()
        {
            Console.WriteLine("-----------------\n Check if entered number is odd or even \n --------------------");
            int numberInput;
            Console.Write("please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                numberInput = Int32.Parse(userInput);
                if (numberInput % 2 == 0)
                {
                    Console.WriteLine("The number you entered is an even number");
                }
                else
                {
                    Console.WriteLine("The number you entered is an odd number");
                }
            }
            catch
            {
                Console.WriteLine("Please check to ensure that the number you entered is a whole number");
            }

            
        }
    }
}
