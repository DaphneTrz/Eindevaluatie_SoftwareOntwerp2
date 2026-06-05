using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Environment.GameMode
{
    public interface IGameMode
    {

        public bool IsGameOver { get; }

        public string WhichMode { get; }

        public int CurrentScore { get; }

        public void Update(GameTime gameTime);

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch);

    }
}
