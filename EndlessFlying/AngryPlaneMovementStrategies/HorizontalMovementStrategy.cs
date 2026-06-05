using EndlessFlyer.Core.Facades;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Objects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.AngryPlaneMovementStrategies
{
    public class HorizontalMovementStrategy : IMovementStrategy
    {
        private int _horizontalDirection = 1;  // 1 = naar rechts, -1 = naar links


        public Vector2 DetermineInvaderMovement(InvaderSprite invader, float elapsedTime)
        {
            // Horizontaal bewegen
            float horizontalFlying = invader.Speed * _horizontalDirection * elapsedTime;


            bool IsAtLeftBoundary() 
                => invader.Position.X + horizontalFlying <= 0;

            bool IsAtRightBoundary() 
                => invader.Position.X + horizontalFlying + invader.Collision.Width >= GameSettings.ScreenWidth;


            if (IsAtLeftBoundary())
            {
                _horizontalDirection = 1;
                horizontalFlying = -invader.Position.X;
            }

            else if (IsAtRightBoundary())
            {
                _horizontalDirection = -1;
                horizontalFlying = GameSettings.ScreenWidth - (invader.Position.X + invader.Collision.Width);
            }

            // Geleidelijk naar beneden
            float verticalFlying = GameSettings.Background_Speed + GameSettings.Plane_VerticalDrift * elapsedTime;


            return new Vector2(horizontalFlying, verticalFlying);
        }
    }
}
