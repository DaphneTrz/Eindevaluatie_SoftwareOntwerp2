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

        public Vector2 DetermineInvaderMovement(Vector2 currentPosition, int objectWidth, float speed, float elapsedTime)
        {

            float verticalFlying = speed * elapsedTime;

            return new Vector2(0, verticalFlying);
        }
    }
}
