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
    public class BlockadeFactory : BaseFactory
    {
        public BlockadeFactory(GameContext context) : base(context) { }


        public BlockadeSprite CreateHouse()
        {
            Texture2D texture = _context.AssetsManager.GetTexture(GetRandomHouseTexture());
            float scale = GameSettings.House_Base_Scale;

            int objectHeight = Convert.ToInt32(texture.Height * scale);

            return new BlockadeSprite(
                texture,
                CreateHorizontalPosition(texture, scale, -objectHeight),
                GameSettings.House_Speed,
                scale
            );
        }


        public BlockadeSprite CreateTree()
        {
            Texture2D texture = _context.AssetsManager.GetTexture(GetRandomTreeTexture());
            float scale = GameSettings.Tree_Base_Scale;

            int objectHeight = Convert.ToInt32(texture.Height * scale);

            return new BlockadeSprite(
                texture,
                CreateHorizontalPosition(texture, scale, -objectHeight),
                GameSettings.Tree_Speed,
                scale
            );
        }


        private string GetRandomHouseTexture()
        {
            switch (_random.Next(2))
            {
                case 0:
                    return AssetNames.HouseBlue_Texture;
                default:
                    return AssetNames.HouseRed_Texture;
            }
        }


        private string GetRandomTreeTexture()
        {
            switch (_random.Next(2))
            {
                case 0:
                    return AssetNames.Tree_Texture;
                default:
                    return AssetNames.Trees_Texture;
            }

        }
    }

}




