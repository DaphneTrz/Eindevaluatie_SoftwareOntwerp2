using EndlessFlyer.Data.Repository;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Data.Repository
{
    public interface IScoreRepository
    {

        public void SaveScore(HighScore score);

        public List<HighScore> GetScores(string gameMode);

        public void DeleteScore(int id);
    }
}


