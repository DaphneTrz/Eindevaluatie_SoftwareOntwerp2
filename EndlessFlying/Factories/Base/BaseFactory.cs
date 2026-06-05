using EndlessFlyer.Core.Facades;
using EndlessFlyer.Environment;
using EndlessFlyer.Identifiers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Factories.Base
{
    public abstract class BaseFactory
    {
        protected readonly GameContext _context;
        protected readonly Random _random;


        public BaseFactory(GameContext context)
        {
            _context = context;
            _random = new Random();
        }


        protected int GetObjectHeight(Texture2D texture, float scale) 
            => Convert.ToInt32(texture.Height * scale);


        protected int GetObjectWidth(Texture2D texture, float scale) 
            => Convert.ToInt32(texture.Width * scale);



        protected Vector2 CreateHorizontalPosition(Texture2D texture, float scale, float verticalPosition)
        {
            int objectWidth = GetObjectWidth(texture, scale);

            float horizontalPosition = _random.Next(0, GameSettings.ScreenWidth - objectWidth);

            return new Vector2(horizontalPosition, verticalPosition);
        }
    }
}
