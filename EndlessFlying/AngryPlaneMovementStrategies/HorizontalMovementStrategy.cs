using EndlessFlyer.Core.Facades;
using EndlessFlyer.Identifiers;
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


        public Vector2 DetermineInvaderMovement(Vector2 currentPosition, int objectWidth, float speed, float elapsedTime)
        {
            // Horizontaal bewegen
            float horizontalFlying = speed * _horizontalDirection * elapsedTime;


            bool IsAtLeftBoundary() => currentPosition.X + horizontalFlying <= 0;
            bool IsAtRightBoundary() => currentPosition.X + horizontalFlying + objectWidth >= GraphicsFacade.GetWindowWidth();


            if (IsAtLeftBoundary())
            {
                _horizontalDirection = 1;
                horizontalFlying = -currentPosition.X;
            }

            else if (IsAtRightBoundary())
            {
                _horizontalDirection = -1;
                horizontalFlying = GraphicsFacade.GetWindowWidth() - (currentPosition.X + objectWidth);
            }

            // Geleidelijk naar beneden
            float verticalFlying = GameSettings.Background_Speed + 20 * elapsedTime;


            return new Vector2(horizontalFlying, verticalFlying);
        }
    }
}
