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

        public void SaveScore(string gameMode, int score);

        public List<int> ShowTopScores(string gameMode);

        public int DeterminePlayerRank(string gameMode, int score);
    }
}
