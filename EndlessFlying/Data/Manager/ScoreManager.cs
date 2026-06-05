using EndlessFlyer.Data.Repository;
using EndlessFlyer.Environment.GameMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Data.Manager
{
    public class ScoreManager
    {
        private readonly IScoreRepository _scoreRepository;

        public ScoreManager(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }



        public List<HighScore> GetTop5Scores(string gameMode)
        {
            return _scoreRepository.GetScores(gameMode)
                                   .OrderByDescending(s => s.Score) 
                                   .Take(5)                       
                                   .ToList();
        }



        public void UpdateHighScore(string gameMode, int score)
        {
            HighScore updateScore = new HighScore { GameMode = gameMode, Score = score };

            _scoreRepository.SaveScore(updateScore);

            var allScores = _scoreRepository.GetScores(gameMode)
                                            .OrderByDescending(s => s.Score)
                                            .ToList();

            if (allScores.Count > 5)
            {
                var scoresToDelete = allScores.Skip(5).ToList();

                foreach (var deleteScore in scoresToDelete)
                {
                    _scoreRepository.DeleteScore(deleteScore.Id);
                }
            }
        }



        public bool IsTop5Score(string gameMode, int score)
        {
            var topScores = GetTop5Scores(gameMode);

            if (topScores.Count < 5) return true;

            return score > topScores.Last().Score;
        }



        public int GetPlayerRank(string gameMode, int score)
        {
            var topScores = GetTop5Scores(gameMode);
            int index = topScores.FindIndex(s => s.Score == score);

            if (index != -1)
            {
                return index + 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
