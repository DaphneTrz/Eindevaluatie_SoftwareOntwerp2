using EndlessFlyer.Identifiers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Environment
{
    public class Background
    {
        private readonly Texture2D _texture;
        private Vector2 _position;


        public Background(GameContext context)
        {
            _texture = context.AssetsManager.GetTexture(AssetNames.Background_Texture);
            _position = Vector2.Zero;
        }



        public void Update(GameTime gameTime)
        {

            _position.Y += GameSettings.Background_Speed;


            // Achtergrond wordt gereset 
            if (_position.Y >= 600f)
            {
                _position.Y = 0f;
            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
            spriteBatch.Draw(_texture, new Vector2(0, _position.Y - 600f), Color.White);
        }
    }
}
