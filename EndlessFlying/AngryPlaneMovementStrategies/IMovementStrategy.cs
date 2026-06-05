using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace EndlessFlyer.AngryPlaneMovementStrategies
{
    public interface IMovementStrategy
    {
        public Vector2 DetermineInvaderMovement(Vector2 currentPosition, int objectWidth, float speed, float elapsedTime);
    }
}
