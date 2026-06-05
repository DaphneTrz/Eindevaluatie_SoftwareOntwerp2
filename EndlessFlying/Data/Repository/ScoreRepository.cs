using LiteDB;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Data.Repository
{
    public class ScoreRepository : IScoreRepository
    {

        private readonly string _connectionString = @"Filename=EndlessFlyerScores.db;Connection=shared";

        private static LiteDatabase _database;

        private ILiteCollection<HighScore> scoreCollection
            => _database.GetCollection<HighScore>("scores");


        public ScoreRepository()
        {

            if (_database == null)
            {
                _database = new LiteDatabase(_connectionString);
            }
        }


        public void SaveScore(HighScore score)
            => scoreCollection.Insert(score);

        public List<HighScore> GetScores(string gameMode)
            => scoreCollection.Find(x => x.GameMode == gameMode).ToList();

        public void DeleteScore(int id)
            => scoreCollection.Delete(id);

    }
}
