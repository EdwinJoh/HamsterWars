using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars.Services
{
    public class PercentCalculator
    {
        public static int ProcentCalculator(int games,int wins)
        {
            decimal number = (decimal)wins/(decimal)games;
            number = Math.Round(number*100);
            return (int)number;
        }
    }
}
