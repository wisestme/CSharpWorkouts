using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# to acceptheight from a user and output the category of the user's height.
 */
namespace Codenza.Services
{
    class ClassifyHeight
    {
        public static void GroupHeight()
        {
            Console.WriteLine("Please enter your height (cm)");

            string userHeightString = Console.ReadLine();
            try
            {
                int userHeight = Int32.Parse(userHeightString);
                if (userHeight < 150)
                {
                    Console.WriteLine("I am sorry to say but you are a dwarf");
                } else if (userHeight >= 150 && userHeight < 165)
                {
                    Console.WriteLine("Your are of average height");
                } else if (userHeight >= 165 && userHeight < 190)
                {
                    Console.WriteLine("You are quite tall");
                } else
                {
                    Console.WriteLine("You are too tall");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format. Please enter whole numbers only. \n Thank you");
            }

        }
    }
}
