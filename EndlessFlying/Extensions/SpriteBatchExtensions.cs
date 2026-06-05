using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Extentions
{
    public static class SpriteBatchExtensions
    {
        public static void Draw(this SpriteBatch spriteBatch, Texture2D texture, Vector2 vector)
        {
            spriteBatch.Draw(texture, vector, Color.White);
        }

        public static void Draw(this SpriteBatch spriteBatch, Texture2D texture, Vector2 vector, float scale)
        {
            spriteBatch.Draw(texture, vector, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
        }

    }
}
