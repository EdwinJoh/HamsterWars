using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events
{
    public class AddHamsterToList
    {
        public static void AddHamster(HamsterModel hamster, List<HamsterModel> hamsterList)
        {
            hamsterList.Add(hamster);
        }
    }
}
