
namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task<List<T>> GetWinner<T, U>(string sql, U parameters);
        Task Savedata<T>(string sql, T parameters);
    }
}