
namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<Hamsters>> GetHamsters();
        Task<List<Hamsters>> FindWinner();
        Task InsertLikes(Hamsters hamsters);
        Task InsertDefeat(Hamsters hamsters);
    }
}