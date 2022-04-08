
namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<Hamsters>> GetHamsters();
        Task InsertLikes(Hamsters hamsters);
        Task InsertDefeat(Hamsters hamsters);
    }
}