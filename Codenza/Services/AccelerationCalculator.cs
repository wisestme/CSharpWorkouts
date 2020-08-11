using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Program to calculate acceleration
 */
namespace Codenza.Services
{
    class AccelerationCalculator
    {
        public static void CalculateAcceleration()
        {
            int v, t, acc;
            Console.WriteLine("Please input velocity value");
            string velocityString = Console.ReadLine();
            Console.WriteLine("Please input time value");
            string timeString = Console.ReadLine();

            try
            {
                v = Int32.Parse(velocityString);
                t = Int32.Parse(timeString);

                acc = v / t;

                Console.WriteLine($"You are accelerating at {acc} m/s" + "\xB2");
            }
            catch
            {
                Console.WriteLine("Please ensure you entered only whole numbers thank you");
            }
        }
    }
}
