using DataAccessLibrary;

namespace Application.Services
{
    public static class GetResults
    {
        public static HamsterModel GetHamsterResult(int id, List<HamsterModel> hamsterList)
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
    }
}
