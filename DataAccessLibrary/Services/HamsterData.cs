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
        private string sql;
        public HamsterData(ISqlDataAccess db)
        {
            this._db = db;
        }
        /// <summary>
        /// This task Gets all the hamsters from the Database
        /// </summary>
        /// <returns></returns>
        public Task<List<HamsterModel>> GetHamsters()
        {
            sql = "select * from dbo.Hamsters";
            return _db.LoadData<HamsterModel, dynamic>(sql, new { });
        }
        /// <summary>
        /// Task that saves our winning hamster object  to the database ( wins and games updated)
        /// </summary>
        /// <param name="hamsters"></param>
        /// <returns></returns>
        public Task InsertLikes(HamsterModel hamsters)
        {
            sql = @"UPDATE dbo.Hamsters set Wins = @Wins +1, Name = @Name, Age = @Age, FavFood = @FavFood, Loves = @Loves, ImgName = @ImgName, Defeats = @Defeats, Games = @Games +1 
                           WHERE ID = @Id ";
            return _db.Savedata(sql, hamsters);
        }
        /// <summary>
        /// Task that saves our loosing hamster object to the databaase ( defeats and game updated)
        /// </summary>
        /// <param name="hamsters"></param>
        /// <returns></returns>
        public Task InsertDefeat(HamsterModel hamsters)
        {
            sql = @"UPDATE dbo.Hamsters set Defeats = @Defeats + 1, Name = @Name, Age = @Age, FavFood = @FavFood, Loves = @Loves, ImgName = @ImgName, Wins = @Wins, Games = @Games +1
                        WHERE ID = @Id ";
            return _db.Savedata(sql, hamsters);
        }
        /// <summary>
        /// Task that saves any new created hamster object to the database.
        /// </summary>
        /// <param name="hamster"></param>
        /// <returns></returns>
        public Task InsertHamster(HamsterModel hamster)
        {
            sql = @"INSERT INTO dbo.Hamsters (Name, Age, FavFood,Loves,ImgName) VALUES (@Name, @Age, @FavFood,@Loves,@ImgName)";
            return _db.Savedata(sql, hamster);
        }
        /// <summary>
        /// Task that remove an hamster from the database
        /// </summary>
        /// <param name="hamster"></param>
        /// <returns></returns>
        public Task RemoveHamster(HamsterModel hamster)
        {
            sql = $"DELETE FROM dbo.Hamsters WHERE Id = {hamster.Id} ";
            return _db.Savedata(sql, hamster);
        }
    }
}
