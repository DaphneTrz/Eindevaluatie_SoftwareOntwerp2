using EndlessFlyer.Environment;
using EndlessFlyer.Environment.GameMode;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Identifiers.Enum;
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
    public class PlayState : AbstractState
    {

        private readonly IGameMode _currentMode;


        public PlayState(GameContext context, IGameMode mode) : base(context)
        {
            _currentMode = mode;
        }


        public override void Update(GameTime gameTime)
        {
            // Pauzescherm oproepen
            if (HasKeyBeenPressed(Keys.Escape))
            {

                Context.ChangeState(new PauseState(Context, this));
                return;
            }


            _currentMode.Update(gameTime);

            // Nagaan of het spel gedaan is
            if (_currentMode.IsGameOver)
            {

                PlayerMode whichGameMode = _currentMode.WhichMode;

                Context.ChangeState(new GameOverState(Context, _currentMode.CurrentScore, whichGameMode));
            }
        }


        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            _currentMode.Draw(gameTime, spriteBatch);


            SpriteFont font = Context.AssetsManager.GetFont(AssetNames.Game_Font);


            spriteBatch.DrawString(font, $"Score: {_currentMode.CurrentScore}", new Vector2(10, 10), Color.White);
        }


    }
}
