using EndlessFlyer.Environment;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndlessFlyer.Objects
{
    public class PlayerScores
    {
        private readonly List<int> _topScores;
        private readonly Vector2 _scoreboardPosition;
        private readonly string _gameMode;


        public PlayerScores(GameContext context, Vector2 scoreboardPosition, string gameMode)
        {
            _scoreboardPosition = scoreboardPosition;
            _gameMode = gameMode;

            _topScores = context.ScoreRepository.ShowTopScores(_gameMode);
        }



        public void Draw(SpriteBatch spriteBatch, SpriteFont font)
        {

            spriteBatch.DrawString(font, _gameMode, _scoreboardPosition, Color.Pink);


            for (int i = 0; i < _topScores.Count; i++)
            {
                spriteBatch.DrawString(font, $"{i + 1}.  {_topScores[i]}", new Vector2(_scoreboardPosition.X, _scoreboardPosition.Y + 40 + (i * 35)), Color.White);
            }


        }
    }
}
