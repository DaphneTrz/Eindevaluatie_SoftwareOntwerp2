using EndlessFlyer.Identifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Spawners
{
    public class HouseSpawner : BaseSpawner
    {
        private readonly Random _random = new Random();

        public HouseSpawner()
        {
        }

        protected override int DetermineSpawnInterval()
        {

            int minSpawn = GameSettings.House_Min_Spawn;
            int maxSpawn = GameSettings.House_Max_Spawn;

            return _random.Next(minSpawn, maxSpawn);

        }
    }
}
