﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenza.Services
{
    class ProcessUserNumber
    {
        public static void DisplayNumberInfo()
        {
            Console.WriteLine("(Check positive/negative) Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
    }
}
