using EndlessFlyer.Objects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.AngryPlaneMovementStrategies
{
    public class VerticalMovementStrategy : IMovementStrategy
    {

        public Vector2 DetermineInvaderMovement(InvaderSprite invader, float elapsedTime)
        {

            float verticalFlying = invader.Speed * elapsedTime;

            return new Vector2(0, verticalFlying);
        }
    }
}
