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

        public ResultData(ISqlDataAccess db)
        {
            this._db = db;
        }
        public Task<List<ResultModel>> Getresult()
        {
            string sql = "Select * from dbo.Results";
            return _db.LoadData<ResultModel, dynamic>(sql, new { });
        }
    }
}
