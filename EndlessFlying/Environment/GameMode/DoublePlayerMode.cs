using EndlessFlyer.Factories;
using EndlessFlyer.Identifiers;
using EndlessFlyer.Input;
using EndlessFlyer.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Environment.GameMode
{
    public class DoublePlayerMode : AbstractGameMode
    {
        public override string WhichMode => "DoublePlayer";

        public DoublePlayerMode(GameContext context) : base(context)
        {
            List<PlayerSprite> players = _context.PlayerFactory.CreateDoublePlayer();

            _characters.Players.Add(players[0]);
            _characters.Players.Add(players[1]);
        }

    }
}
