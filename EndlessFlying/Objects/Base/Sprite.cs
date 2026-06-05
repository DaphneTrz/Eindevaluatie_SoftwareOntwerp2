using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using EndlessFlyer.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndlessFlyer.Objects.Base
{
    public class Sprite
    {

        public Texture2D Texture { get; init; }
        public float Speed { get; init; }
        public float Scale { get; init; }

        public Vector2 Position { get; protected set; }



        public Sprite(Texture2D texture, Vector2 position, float speed, float scale)
        {
            Texture = texture;
            Position = position;
            Speed = speed;
            Scale = scale;
        }


        // Botsingsgebied

        public Rectangle Collision => new Rectangle(
             (int)Position.X,
             (int)Position.Y,
             (int)(Texture.Width * Scale),
             (int)(Texture.Height * Scale));


        public virtual void Update(GameTime gameTime)
        {
        }


        public virtual void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(Texture, Position, Scale);
        }


        public void UpdatePosition(float xChange, float yChange)
        {
            // X en Y waardes worden vervangen door nieuwe waarden
            Position = Position with
            {
                X = Position.X + xChange,
                Y = Position.Y + yChange
            };
        }


        // We willen enkel horizontaal bewegen, dus geven we een 0 mee als tweede waarde
        public void UpdateHorizontalPosition(float xChange)
            => UpdatePosition(xChange, 0);



        // We willen enkel verticaal bewegen, dus geven we een 0 mee als eerste waarde
        public void UpdateVerticalPosition(float yChange)
            => UpdatePosition(0, yChange);
    }
}



