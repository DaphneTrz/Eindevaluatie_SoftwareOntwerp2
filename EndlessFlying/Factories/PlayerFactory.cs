using EndlessFlyer.Core.Facades;
using EndlessFlyer.Environment;
using EndlessFlyer.Factories.Base;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Input;
using EndlessFlyer.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndlessFlyer.Factories
{
    public class PlayerFactory : BaseFactory
    {
        public PlayerFactory(GameContext context) 
            : base(context) { }


        private PlayerSprite CreatePlayer(IPlayerInputService inputService)
        {
            Texture2D texture = _context.AssetsManager.GetTexture(AssetNames.Player_Texture);
            float scale = GameSettings.Player_Scale;

            float verticalPosition = GameSettings.ScreenHeight - GameSettings.Player_BottomMargin;

            // Startpositie speler
            Vector2 startPosition = CreateHorizontalPosition(texture, scale, verticalPosition);


            return new PlayerSprite(
                texture,
                startPosition,
                GameSettings.Player_Speed,
                scale,
                inputService
            );
        }


        public PlayerSprite CreateSinglePlayer()
        {
            return CreatePlayer(PlayerInputService.CombinedSet());
        }


        public List<PlayerSprite> CreateDoublePlayer()
        {
            return new List<PlayerSprite>
           {
              CreatePlayer(PlayerInputService.ButtonsetOne()),
              CreatePlayer(PlayerInputService.ButtonsetTwo())
           };
        }

    }
}
