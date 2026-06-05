using EndlessFlyer.Core.Assets;
using EndlessFlyer.Data;
using EndlessFlyer.Data.Manager;
using EndlessFlyer.Data.Repository;
using EndlessFlyer.Factories;
using EndlessFlyer.Objects;
using EndlessFlyer.Objects.Base;
using EndlessFlyer.States;
using EndlessFlyer.States.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Environment
{
    public class GameContext
    {
        public AbstractState CurrentState { get; private set; }
        public AssetsManager AssetsManager { get; }
        public IScoreRepository ScoreRepository { get; }
        public ScoreManager ScoreManager { get; private set; }

        public BlockadeFactory BlockadeFactory { get; }
        public InvaderFactory InvaderFactory { get; }
        public PlayerFactory PlayerFactory { get; }


        public GameContext(Game game)
        {
            AssetsManager = new AssetsManager(game);
            ScoreRepository = new ScoreRepository();
            ScoreManager = new ScoreManager(ScoreRepository);

            BlockadeFactory = new BlockadeFactory(this);
            InvaderFactory = new InvaderFactory(this);
            PlayerFactory = new PlayerFactory(this);

            CurrentState = new MenuState(this);
        }

        public void ChangeState(AbstractState newActiveState)
        {
            CurrentState = newActiveState;
        }

        public void Update(GameTime gameTime)
        {
            CurrentState.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            CurrentState.Draw(gameTime, spriteBatch);
        }
    }
}
