using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars.Services
{
    public class PercentCalculator
    {
        public static int WinRateCalculator(int wins, int games)
        {
            if (games == 0)
            {
                return 0;
            }
            else
            {
                decimal number = (decimal)wins / (decimal)games;
                number = Math.Round(number * 100);
                return (int)number;
            }
        }
    }
}
