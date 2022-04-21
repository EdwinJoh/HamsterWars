using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ResultData : IResultData
    {
        private readonly ISqlDataAccess _db;
        private string sql;
        public ResultData(ISqlDataAccess db)
        {
            this._db = db;
        }
        /// <summary>
        /// Gets all the results from the database
        /// </summary>
        /// <returns></returns>
        public Task<List<ResultModel>> Getresult()
        {
             sql = "Select * from dbo.Results";
            return _db.LoadData<ResultModel, dynamic>(sql, new { });
        }
        /// <summary>
        /// Insert battle result to the database
        /// </summary>
        /// <param name="battleResult"></param>
        /// <returns></returns>
        public Task InsertBattle(ResultModel battleResult)
        {
             sql = $"INSERT INTO dbo.Results( WinnerId,LoserId) VALUES ({battleResult.WinnerId}, {battleResult.LoserId})";
            return _db.Savedata(sql, battleResult);
        }
        /// <summary>
        /// Removes one result from the database
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public Task RemoveOneResult(ResultModel result)
        {
             sql = $"DELETE FROM dbo.Results WHERE ID ={result.Id}";
            return _db.Savedata(sql, result);
        }
        /// <summary>
        /// Removes all the results from the database 
        /// </summary>
        public Task RemoveAllResults()
        {
             sql = "DELETE FROM dbo.Results";
            return _db.Savedata(sql, new { });
        }
       
    }
}
