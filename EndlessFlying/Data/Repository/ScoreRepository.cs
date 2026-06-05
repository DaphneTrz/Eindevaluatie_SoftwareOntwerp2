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

        public void SaveScore(string gameMode, int score)
        {

            using (LiteDatabase db = new LiteDatabase(_connectionString))
            {

                ILiteCollection<HighScore> collection = db.GetCollection<HighScore>("scores");

                HighScore insertedScore = new HighScore
                {
                    GameMode = gameMode,
                    Score = score
                };

                collection.Insert(insertedScore);

                RemoveScore(collection, gameMode);
            }
        }


        private void RemoveScore(ILiteCollection<HighScore> collection, string gameMode)
        {

            // Zoeken volgens de huidige gamemodus
            List<HighScore> scores = collection.Find(x => x.GameMode == gameMode)
                                               .OrderByDescending(x => x.Score)
                                               .ToList();


            // Bij meer dan 5 scores, behoudt de 5 beste en verwijder de rest 
            if (scores.Count > 5)
            {
                var scoresToRemove = scores.Skip(5);
                foreach (var toDelete in scoresToRemove)
                {
                    collection.Delete(toDelete.Id);
                }
            }

        }


        public List<int> ShowTopScores(string gameMode)
        {
            using (LiteDatabase db = new LiteDatabase(_connectionString))
            {
                ILiteCollection<HighScore> collection = db.GetCollection<HighScore>("scores");

                return collection.Find(x => x.GameMode == gameMode)
                                 .OrderByDescending(x => x.Score)
                                 .Select(x => x.Score)
                                 .Take(5)
                                 .ToList();
            }
        }


        public int DeterminePlayerRank(string gameMode, int score)
        {

            List<int> topScores = ShowTopScores(gameMode);

            for (int i = 0; i < topScores.Count; i++)
            {
                if (topScores[i] == score)
                {
                    return i + 1;
                }
            }

            return -1; // Niet in de top 5 gevonden
        }


    }
}
