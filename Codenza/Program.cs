using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codenza;
using Codenza.Services;

namespace Codenza
{
    class Program
    {
        public static void Main()
        {
            ArrayAverageCalculator.HowManyOne();

            ArrayAverageCalculator.GetArrayAverage();

            DaysAdd.DynamicDateAdder();

            DaysAdd.DaysAdder();

            ProcessUserNumber.DisplayNumberInfo();

            ClassifyHeight.GroupHeight();

            AccelerationCalculator.CalculateAcceleration();

            LeapYearChecker obj = new LeapYearChecker();
            obj.ReadData();
            obj.LeapCondition();

            OddEven.CheckOddEven();
        }
    }
}
