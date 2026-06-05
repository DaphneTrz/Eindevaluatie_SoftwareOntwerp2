using EndlessFlyer.AngryPlaneMovementStrategies;
using EndlessFlyer.Core.Facades;
using EndlessFlyer.Environment;
using EndlessFlyer.Factories.Base;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndlessFlyer.Factories
{
    public class InvaderFactory : BaseFactory
    {
        public InvaderFactory(GameContext context) : base(context) { }


        public InvaderSprite CreateAngryPlane()
        {
            Texture2D texture = _context.AssetsManager.GetTexture(GetRandomInvaderTexture());
            float scale = GameSettings.Plane1_Base_Scale;

            int objectHeight = Convert.ToInt32(texture.Height * scale);

            IMovementStrategy strategy;
            float speed = GameSettings.Plane_Speed;

            switch (_random.Next(2))
            {
                case 0:
                    strategy = new HorizontalMovementStrategy(); break;
                default:
                    strategy = new VerticalMovementStrategy(); break;

            }

            return new InvaderSprite(
                texture,
                CreateHorizontalPosition(texture, scale, objectHeight),
                speed,
                scale,
                strategy
            );
        }


        private string GetRandomInvaderTexture()
        {

            switch (_random.Next(2))
            {
                case 0:
                    return AssetNames.Plane1_Texture;
                default:
                    return AssetNames.Plane2_Texture;
            }

        }
    }
}
