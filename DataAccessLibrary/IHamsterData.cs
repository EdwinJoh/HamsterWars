
namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<HamsterModel>> GetHamsters();
        Task InsertLikes(HamsterModel hamsters);
        Task GetHamster(int id);
        Task RemoveHamster(HamsterModel hamsters);
        Task InsertHamster(HamsterModel hamsters);
        Task InsertDefeat(HamsterModel hamsters);
    }
}