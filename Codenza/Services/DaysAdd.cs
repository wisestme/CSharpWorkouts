using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenza.Services
{
    class DaysAdd
    {
        public static void DaysAdder()
        {   //date of reference
            DateTime dayref = new DateTime(2015, 6, 14);
            Console.WriteLine($"Starting date is {dayref}");

            DateTime daycurrent = dayref.AddDays(10);
            Console.WriteLine($"New date after addition is {daycurrent}");

            if (dayref < daycurrent)
                Console.WriteLine($"{dayref} occurs before {daycurrent}");
            else
                Console.WriteLine($"{dayref} occurs after {daycurrent}");
        }

        // Add days from user input
        public static void DynamicDateAdder()
        {
            var ukCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Please enter a date:" + ukCulture.DateTimeFormat.ShortDatePattern);

            string userDateString = Console.ReadLine();

            DateTime userDate;

            if (DateTime.TryParse(userDateString, ukCulture.DateTimeFormat, System.Globalization.DateTimeStyles.None, out userDate))
                Console.WriteLine("Valid date format entered");
            else
                Console.WriteLine("Invalid date format entered");

            Console.WriteLine("How many days would you like to add");
            string daysToAddString = Console.ReadLine();

            int daysToAdd = Int32.Parse(daysToAddString);

            DateTime dayCurrent = userDate.AddDays(daysToAdd);
            Console.WriteLine(dayCurrent);
        }
    }
}
