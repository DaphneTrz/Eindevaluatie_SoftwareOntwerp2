using EndlessFlyer.Core.Assets;
using EndlessFlyer.Core.Facades;
using EndlessFlyer.Environment;
using EndlessFlyer.Identifiers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EndlessFlyer
{
    public class Game1 : Game
    {
        private GameContext _gameContext;

        private SpriteBatch _spriteBatch;

        public Game1()
        {
            GraphicsFacade.Initialize
                (this, width: GameSettings.ScreenWidth, 
                height: GameSettings.ScreenHeight);

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }


        protected override void Initialize()
        {

            _gameContext = new GameContext(this);

            base.Initialize();
        }


        protected override void LoadContent()
        {

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }


        protected override void Update(GameTime gameTime)
        {

            KeyboardFacade.Update();

            if (KeyboardFacade.HasKeyBeenPressed(Keys.X))
            {
                Exit();
            }

            _gameContext.Update(gameTime);

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _gameContext.Draw(gameTime, _spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
