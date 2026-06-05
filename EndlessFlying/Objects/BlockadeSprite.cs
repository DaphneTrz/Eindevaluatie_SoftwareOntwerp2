using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndlessFlyer.Objects.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EndlessFlyer.Objects
{
    public class BlockadeSprite : Sprite
    {

        public BlockadeSprite(Texture2D texture, Vector2 position, float speed, float scale)
            : base(texture, position, speed, scale)
        {
        }



        public override void Update(GameTime gameTime)
        {

            UpdateVerticalPosition(Speed);
        }
    }
}
