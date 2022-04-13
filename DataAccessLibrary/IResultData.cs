using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IResultData
    {
        Task<List<ResultModel>> Getresult();
        Task InsertBattle(ResultModel battleResult);
    }
}