
namespace DataAccessLibrary
{
    public interface IHamsterData
    {
        Task<List<Hamsters>> GetHamsters();
    }
}