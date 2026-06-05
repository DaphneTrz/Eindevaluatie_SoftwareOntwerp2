using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndlessFlyer.Core.Exceptions;
using Microsoft.Xna.Framework;

namespace EndlessFlyer.Core.Facades
{
    public static class GraphicsFacade
    {

        private static GraphicsDeviceManager _graphics;


        public static void Initialize(Game game, int width, int height)
        {

            _graphics = new GraphicsDeviceManager(game)
            {
                PreferredBackBufferWidth = width,
                PreferredBackBufferHeight = height
            };
        }


        public static int GetWindowHeight()
        {
            if (_graphics == null)
            {
                throw new GraphicsFacadeNotInitializedException();
            }

            return _graphics.PreferredBackBufferHeight;
        }


        public static int GetWindowWidth()
        {
            if (_graphics == null)
            {
                throw new GraphicsFacadeNotInitializedException();
            }

            return _graphics.PreferredBackBufferWidth;
        }



    }
}
