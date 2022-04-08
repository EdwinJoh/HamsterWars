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
            string sql = @"UPDATE dbo.Hamsters set Wins = @Wins, Name = @Name, Age = @Age, FavFood = @FavFood, Loves = @Loves, ImgName = @ImgName, Defeats = @Defeats, Games = @Games WHERE ID = @Id ";



            return _db.Savedata(sql, hamsters);
        }

    }
}
