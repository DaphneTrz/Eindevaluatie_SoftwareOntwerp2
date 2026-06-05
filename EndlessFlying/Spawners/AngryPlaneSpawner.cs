using EndlessFlyer.Identifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Spawners
{
    public class AngryPlaneSpawner : BaseSpawner
    {
        private readonly Random _random = new Random();

        public AngryPlaneSpawner() : base()  { }



        protected override int DetermineSpawnInterval()
        {

            int minSpawn = GameSettings.Plane_Min_Spawn;
            int maxSpawn = GameSettings.Plane_Max_Spawn;

            return _random.Next(minSpawn, maxSpawn);

        }
    }
}
