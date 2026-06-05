using EndlessFlyer.Environment;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Identifiers.Enum;
using EndlessFlyer.States.Base;
using EndlessFlyer.Objects;
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
    public class TopScoreState : AbstractState
    {

        private readonly PlayerScores _singlePlayerScores;
        private readonly PlayerScores _doublePlayerScores;


        public TopScoreState(GameContext context) : base(context)
        {

            _singlePlayerScores = new PlayerScores(context, new Vector2(130, 125), PlayerMode.SinglePlayer);
            _doublePlayerScores = new PlayerScores(context, new Vector2(130, 380), PlayerMode.DoublePlayer);
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

            spriteBatch.DrawString(font, "TopScores", new Vector2(140, 30), Color.OrangeRed);


            _singlePlayerScores.Draw(spriteBatch, font);
            _doublePlayerScores.Draw(spriteBatch, font);

            spriteBatch.DrawString(font, "Ga terug: druk Escape", new Vector2(40, 670), Color.Orange);
        }
    }
}
