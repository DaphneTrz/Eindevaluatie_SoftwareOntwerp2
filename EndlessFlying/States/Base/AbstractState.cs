using EndlessFlyer.Core.Facades;
using EndlessFlyer.Environment;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.States.Base
{
    public abstract class AbstractState
    {
        protected GameContext Context { get; init; }

        public AbstractState(GameContext context)
        {
            Context = context;
        }

        public abstract void Update(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);


        protected bool IsKeyDown(Keys key)
            => KeyboardFacade.IsKeyDown(key);


        protected bool HasKeyBeenPressed(Keys key)
            => KeyboardFacade.HasKeyBeenPressed(key);
    }
}
