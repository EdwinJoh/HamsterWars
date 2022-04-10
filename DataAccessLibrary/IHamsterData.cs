
namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<HamsterModel>> GetHamsters();
        Task<List<HamsterModel>> FindWinner();
        Task<List<HamsterModel>> TopTenWinners();
        Task InsertLikes(HamsterModel hamsters);
        Task InsertDefeat(HamsterModel hamsters);
    }
}