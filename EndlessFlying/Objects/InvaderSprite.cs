using EndlessFlyer.AngryPlaneMovementStrategies;
using EndlessFlyer.Objects.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Objects
{
    public class InvaderSprite : Sprite
    {

        private readonly IMovementStrategy _movementStrategy;


        public InvaderSprite(Texture2D texture, Vector2 position, float speed, float scale, IMovementStrategy movementStrategy)
            : base(texture, position, speed, scale)
        {
            _movementStrategy = movementStrategy;
        }



        public override void Update(GameTime gameTime)
        {

            float elapsedTime = Convert.ToSingle(gameTime.ElapsedGameTime.TotalSeconds);

            Vector2 movement = _movementStrategy.DetermineInvaderMovement(this, elapsedTime);

            UpdatePosition(movement.X, movement.Y);
        }
    }
}
