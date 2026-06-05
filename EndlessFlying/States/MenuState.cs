using EndlessFlyer.Environment;
using EndlessFlyer.Environment.GameMode;
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
    public class MenuState : AbstractState
    {

        public MenuState(GameContext context) : base(context)
        {
        }


        public override void Update(GameTime gameTime)
        {

            // Kiezen voor SinglePlayerMode
            if (HasKeyBeenPressed(Keys.NumPad1) || HasKeyBeenPressed(Keys.D1))
            {
                Context.ChangeState(new PlayState(Context, new SinglePlayerMode(Context)));
            }

            // Kiezen voor DoublePlayerMode
            if (HasKeyBeenPressed(Keys.NumPad2) || HasKeyBeenPressed(Keys.D2))
            {
                Context.ChangeState(new PlayState(Context, new DoublePlayerMode(Context)));
            }

            // Navigeren naar TopScoreState
            if (HasKeyBeenPressed(Keys.NumPad3) || HasKeyBeenPressed(Keys.D3))
            {
                Context.ChangeState(new TopScoreState(Context));
            }
        }



        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            var font = Context.AssetsManager.GetFont(AssetNames.Game_Font);

            spriteBatch.DrawString(font, "Endless Flyer Menu", new Vector2(50, 100), Color.OrangeRed);
            spriteBatch.DrawString(font, "Press 1 - SinglePlayer", new Vector2(40, 200), Color.Pink);
            spriteBatch.DrawString(font, "Press 2 - DoublePlayer", new Vector2(40, 250), Color.Pink);
            spriteBatch.DrawString(font, "Press 3 - Topscores", new Vector2(40, 300), Color.Pink);

        }

    }
}
