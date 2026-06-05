using EndlessFlyer.Input;
using EndlessFlyer.Objects.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using EndlessFlyer.Core.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndlessFlyer.Objects
{
    public class PlayerSprite : Sprite
    {

        private readonly IPlayerInputService _inputService;


        public PlayerSprite(Texture2D texture, Vector2 position, float speed, float scale,
                            IPlayerInputService inputService)
            : base(texture, position, speed, scale)
        {
            _inputService = inputService;
        }


        public override void Update(GameTime gameTime)
        {

            if (_inputService.MoveUp())
                UpdateVerticalPosition(-Speed);

            if (_inputService.MoveDown())
                UpdateVerticalPosition(+Speed);

            if (_inputService.MoveLeft())
                UpdateHorizontalPosition(-Speed);

            if (_inputService.MoveRight())
                UpdateHorizontalPosition(+Speed);

        }

    }
}


