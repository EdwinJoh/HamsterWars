﻿using System;
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
        public Task<List<HamsterModel>> GetHamsters()
        {
            string sql = "select * from dbo.Hamsters";
            return _db.LoadData<HamsterModel, dynamic>(sql, new { });
        }
        public Task<List<HamsterModel>> FindWinner() /// stor bokstav ==????
        {
            string sql = @"Select * from Hamsters where wins = (select MAX(wins) from Hamsters)";
            return _db.GetWinner<HamsterModel, dynamic>(sql, new { });

        }
        public Task InsertLikes(HamsterModel hamsters)
        {
            string sql = @"UPDATE dbo.Hamsters set Wins = @Wins, Name = @Name, Age = @Age, FavFood = @FavFood, Loves = @Loves, ImgName = @ImgName, Defeats = @Defeats, Games = @Games, winRate = @winRate, LossRate = @LossRate  WHERE ID = @Id ";
            return _db.Savedata(sql, hamsters);
        }
        public Task InsertDefeat(HamsterModel hamsters)
        {
            string sql = @"UPDATE dbo.Hamsters set Defeats = @Defeats, Name = @Name, Age = @Age, FavFood = @FavFood, Loves = @Loves, ImgName = @ImgName, Wins = @Wins, Games = @Games, winRate = @winRate, LossRate = @LossRate WHERE ID = @Id ";
            return _db.Savedata(sql, hamsters);
        }

    }
}
