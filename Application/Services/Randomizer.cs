using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class Randomizer
    {
        public static (HamsterModel, HamsterModel) Gethamster(List<HamsterModel> hamsters)
        {
            if (hamsters == null)
            {
                // return new list so its does not stop the app
                return (null, null);
            }
            else
            {
                Random random = new Random();

                HamsterModel hamster1 = hamsters[random.Next(0, hamsters.Count)];
                HamsterModel hamster2 = hamsters[random.Next(0, hamsters.Count)];

                while (hamster1.Id == hamster2.Id)
                {
                    hamster2 = hamsters[random.Next(0, hamsters.Count)];
                }
                return (hamster1, hamster2);

            }
        }
    }
}
