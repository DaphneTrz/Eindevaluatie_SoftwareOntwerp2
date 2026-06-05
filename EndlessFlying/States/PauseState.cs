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
    public class PauseState : AbstractState
    {
        // Onthoudt welk spel er bezig is
        private readonly AbstractState _playState;


        public PauseState(GameContext context, AbstractState playState) : base(context)
        {
            _playState = playState;
        }

        public override void Update(GameTime gameTime)
        {

            if (HasKeyBeenPressed(Keys.Escape))
            {
                Context.ChangeState(_playState);
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // originele PlayState wordt gerenderd
            _playState.Draw(gameTime, spriteBatch);


            SpriteFont font = Context.AssetsManager.GetFont(AssetNames.Game_Font);


            spriteBatch.DrawString(font, "Pauze", new Vector2(180, 250), Color.OrangeRed);
            spriteBatch.DrawString(font, "Druk op Escape", new Vector2(100, 350), Color.Orange);
            spriteBatch.DrawString(font, "om verder te doen", new Vector2(80, 400), Color.Orange);
        }
    }
}
