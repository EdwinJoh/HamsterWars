
namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<HamsterModel>> GetHamsters();
        Task<List<HamsterModel>> FindWinner();
        Task InsertLikes(HamsterModel hamsters);
        Task InsertDefeat(HamsterModel hamsters);
    }
}