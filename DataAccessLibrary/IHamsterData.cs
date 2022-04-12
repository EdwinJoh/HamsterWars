
namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<HamsterModel>> GetHamsters();
        Task<List<HamsterModel>> FindWinner();
        Task<List<HamsterModel>> Topfive();
        Task InsertLikes(HamsterModel hamsters);
        Task RemoveHamster(HamsterModel hamsters);
        Task InsertHamster(HamsterModel hamsters);
        Task InsertDefeat(HamsterModel hamsters);
    }
}