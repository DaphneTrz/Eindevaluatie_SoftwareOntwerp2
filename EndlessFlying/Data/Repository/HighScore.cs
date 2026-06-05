using EndlessFlyer.Identifiers.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Data.Repository
{
    public class HighScore
    {
        public int Id { get; set; }

        public PlayerMode GameMode { get; set; } // singleplayer of doubleplayer

        public int Score { get; set; }

    }
}
