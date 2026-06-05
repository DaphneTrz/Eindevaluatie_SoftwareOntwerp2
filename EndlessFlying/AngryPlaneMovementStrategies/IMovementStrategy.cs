using EndlessFlyer.Objects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.AngryPlaneMovementStrategies
{
    public interface IMovementStrategy
    {
        public Vector2 DetermineInvaderMovement(InvaderSprite invader, float elapsedTime);
    }
}
