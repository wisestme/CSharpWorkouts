using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenza.Services
{
    class LeapYearChecker
    {
        //static void LeapYearCheck()
        //{
            
        //    obj.ReadData();
        //    obj.LeapCondition();
        //}
        int yearValue;
        public void ReadData()
        {
            Console.WriteLine("Enter the year in four digits");
            string yearString = Console.ReadLine();
            try
            {
                yearValue = Int32.Parse(yearString);
            }
            catch
            {
                Console.WriteLine("The year input must be four digits.");
            }
        }

        public void LeapCondition()
        {
            if ((yearValue % 4 == 0 && yearValue % 100 != 0) || (yearValue % 400 == 0))
            {
                Console.WriteLine($"{yearValue} is a leap year");
            }
            else
            {
                Console.WriteLine($"{yearValue} is not a leap year");
            }
        }
    }
}
