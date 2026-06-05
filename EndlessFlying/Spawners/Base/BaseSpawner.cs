using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace EndlessFlyer.Spawners
{
    public abstract class BaseSpawner
    {
        private double _timer;
        private int _nextSpawn;
        private bool _isInitialized;

        public BaseSpawner()
        {
            _timer = 0f;
            _isInitialized = false;
        }

        protected abstract int DetermineSpawnInterval();


        public bool Update(GameTime gameTime)
        {

            if (!_isInitialized)
            {
                _nextSpawn = DetermineSpawnInterval();
                _isInitialized = true;
            }

            _timer += gameTime.ElapsedGameTime.TotalMilliseconds;


            if (_timer >= _nextSpawn)
            {
                _timer = 0f;
                _nextSpawn = DetermineSpawnInterval();
                return true;
            }

            return false;
        }
    }
}
