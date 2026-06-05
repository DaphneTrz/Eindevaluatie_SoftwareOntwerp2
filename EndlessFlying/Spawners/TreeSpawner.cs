using EndlessFlyer.Identifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Spawners
{
    public class TreeSpawner : BaseSpawner
    {
        private readonly Random _random = new Random();

        public TreeSpawner() : base() { }



        protected override int DetermineSpawnInterval()
        {

            int minSpawn = GameSettings.Tree_Min_Spawn;
            int maxSpawn = GameSettings.Tree_Max_Spawn;

            return _random.Next(minSpawn, maxSpawn);

        }
    }
}
