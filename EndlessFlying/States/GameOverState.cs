using EndlessFlyer.Environment;
using EndlessFlyer.Identifiers;
using EndlessFlyer.States.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndlessFlyer.States
{
    public class GameOverState : AbstractState
    {

        private readonly int _score;
        private readonly string _whichGameMode;
        private List<int> _topScores;
        private int _playerPositionTopScores = -1;      // -1 = niet gevonden



        public GameOverState(GameContext context, int score, string whichGameMode)
        : base(context)
        {
            _score = score;
            _whichGameMode = whichGameMode;


            Context.ScoreRepository.SaveScore(_whichGameMode, _score);

            // Vernieuwde topscores worden opgehaald 
            _topScores = Context.ScoreRepository.ShowTopScores(_whichGameMode);

            // Positie opvragen
            _playerPositionTopScores = Context.ScoreRepository.DeterminePlayerRank(_whichGameMode, _score);
        }


        public override void Update(GameTime gameTime)
        {

            if (HasKeyBeenPressed(Keys.Escape))
            {
                Context.ChangeState(new MenuState(Context));
            }

        }


        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            SpriteFont font = Context.AssetsManager.GetFont(AssetNames.Game_Font);

            spriteBatch.DrawString(font, "Game Over", new Vector2(130, 50), Color.OrangeRed);
            spriteBatch.DrawString(font, $"Top 5 - {_whichGameMode}", new Vector2(57, 120), Color.Pink);


            for (int i = 0; i < _topScores.Count; i++)
            {
                Color color;
                switch (_playerPositionTopScores == i + 1)
                {
                    case true: color = Color.Violet; break;
                    case false: color = Color.White; break;
                }

                spriteBatch.DrawString(font, $"{i + 1}. {_topScores[i]}", new Vector2(180, 190 + (i * 35)), color);
            }


            spriteBatch.DrawString(font, $"Je scoorde: {_score}", new Vector2(105, 420), Color.Violet);
            spriteBatch.DrawString(font, "Ga terug: druk Escape", new Vector2(40, 620), Color.Orange);
        }
    }
}
