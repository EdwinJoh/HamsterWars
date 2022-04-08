using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class HamsterData : IHamsterData
    {
        private readonly ISqlDataAccess _db;

        public HamsterData(ISqlDataAccess db)
        {
           this._db = db;
        }
        public Task<List<Hamsters>> GetHamsters()
        {
            string sql = "select * from dbo.Hamsters";
            return _db.LoadData<Hamsters, dynamic>(sql, new { });
        }
       public Task InsertLikes(Hamsters hamsters)
        {
            string sql = $"update Hamsters set Wins = Wins+1 where id =1";
            return _db.Savedata(sql, hamsters);
        }

    }
}
