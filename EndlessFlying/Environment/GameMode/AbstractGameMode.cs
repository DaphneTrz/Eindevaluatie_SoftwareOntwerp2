using EndlessFlyer.Core.Facades;
using EndlessFlyer.Factories;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Identifiers.Enum;
using EndlessFlyer.Objects;
using EndlessFlyer.Objects.Base;
using EndlessFlyer.Spawners;
using EndlessFlyer.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace EndlessFlyer.Environment.GameMode
{
    public abstract class AbstractGameMode : IGameMode
    {
        protected GameContext _context;
        protected IntroducingCharacters _characters;
        private readonly Background _background;

        private double _scoreTimer;

        public bool IsGameOver { get; protected set; }
        public abstract PlayerMode WhichMode { get; }



        public AbstractGameMode(GameContext context)
        {

            _context = context;
            _characters = new IntroducingCharacters(context);
            _background = new Background(context);

        }


        public virtual void Update(GameTime gameTime)
        {
            if (IsGameOver) return;

            _scoreTimer += gameTime.ElapsedGameTime.TotalSeconds;

            _background.Update(gameTime);
            _characters.Update(gameTime);

            WhenPlaneCrashes();
        }



        public int CurrentScore
            => Convert.ToInt32(_scoreTimer * 10.0);




        public void WhenPlaneCrashes()
        {
            if (IsGameOver)
                return;

            foreach (var player in _characters.Players)
            {
                Rectangle crashArea = player.Collision;


                foreach (var threat in _characters.Threats)
                {
                    if (threat.Collision.Intersects(crashArea))
                    {
                        IsGameOver = true;
                        return;
                    }
                }
            }
        }



        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            _background.Draw(spriteBatch);

            _characters.Draw(spriteBatch);
        }

    }
}

