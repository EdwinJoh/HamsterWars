using DataAccessLibrary;

namespace HamsterWars.Services
{
    public static class GetResults
    {

        public static HamsterModel GetWinner(int id, List<HamsterModel> hamsterList)
        {
            if (hamsterList.Any(i => i.Id == id))
            {
                return hamsterList.Where(s => s.Id == id).Single();

            }
            else
            {
                return new HamsterModel
                {
                    Name = "Unknown"
                };
            }
        }
        public static HamsterModel GetLoser(int id, List<HamsterModel> hamsterList)
        {
            if (hamsterList.Any(i => i.Id == id))
            {
               return hamsterList.Where(c => c.Id == id).Single();
            }
            else
            {
                return new HamsterModel { Name ="Unknown" };
            }
        }
    }
}
