using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace EndlessFlyer.Core.Facades
{
    public static class KeyboardFacade
    {
        private static KeyboardState _currentKeyState;
        private static KeyboardState _previousKeyState;

        public static void Update()
        {

            _previousKeyState = _currentKeyState;
            _currentKeyState = Keyboard.GetState();
        }


        public static bool IsKeyDown(Keys key)
        {

            return _currentKeyState.IsKeyDown(key);
        }


        public static bool HasKeyBeenPressed(Keys key)
        {

            return _currentKeyState.IsKeyDown(key) && !_previousKeyState.IsKeyDown(key);
        }

    }
}
