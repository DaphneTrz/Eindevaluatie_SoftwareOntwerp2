using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndlessFlyer.Core.Facades;
using Microsoft.Xna.Framework.Input;


namespace EndlessFlyer.Input
{
    public class PlayerInputService : IPlayerInputService
    {
        private readonly Keys _up;
        private readonly Keys _down;
        private readonly Keys _left;
        private readonly Keys _right;
        private readonly PlayerInputService _extraSet;


        private PlayerInputService(Keys up, Keys down, Keys left, Keys right, PlayerInputService extraSet)
        {
            _up = up;
            _down = down;
            _left = left;
            _right = right;
            _extraSet = extraSet;
        }


        public static PlayerInputService ButtonsetOne() =>
            new PlayerInputService(Keys.Up, Keys.Down, Keys.Left, Keys.Right, null);


        public static PlayerInputService ButtonsetTwo() =>
            new PlayerInputService(Keys.Z, Keys.S, Keys.Q, Keys.D, null);


        public static PlayerInputService CombinedSet() =>
            new PlayerInputService(Keys.Up, Keys.Down, Keys.Left, Keys.Right, ButtonsetTwo());



        public bool MoveUp() => 
            KeyboardFacade.IsKeyDown(_up) || _extraSet?.MoveUp() == true;

        public bool MoveDown() => 
            KeyboardFacade.IsKeyDown(_down) || _extraSet?.MoveDown() == true;

        public bool MoveLeft() => 
            KeyboardFacade.IsKeyDown(_left) || _extraSet?.MoveLeft() == true;

        public bool MoveRight() => 
            KeyboardFacade.IsKeyDown(_right) || _extraSet?.MoveRight() == true;

    }
}



