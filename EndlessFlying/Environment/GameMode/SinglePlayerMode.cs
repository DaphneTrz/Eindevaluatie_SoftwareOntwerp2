using EndlessFlyer.Factories;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Identifiers.Enum;
using EndlessFlyer.Input;
using EndlessFlyer.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Environment.GameMode
{
    public class SinglePlayerMode : AbstractGameMode
    {
        public override PlayerMode WhichMode { get; } = PlayerMode.SinglePlayer;

        public SinglePlayerMode(GameContext context) : base(context)
        {
            _characters.Players.Add(_context.PlayerFactory.CreateSinglePlayer());
        }


        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }
    }
}
