using EndlessFlyer.Factories;
using EndlessFlyer.Objects;
using EndlessFlyer.Objects.Base;
using EndlessFlyer.Spawners;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Environment
{
    public class IntroducingCharacters
    {
        private readonly GameContext _context;

        private readonly HouseSpawner _houseSpawner;
        private readonly TreeSpawner _treeSpawner;
        private readonly AngryPlaneSpawner _angryPlaneSpawner;

        public List<PlayerSprite> Players { get; }

        // Gezamelijke lijst blockades en invaders
        public List<Sprite> Threats { get; }


        public IntroducingCharacters(GameContext context)
        {
            _context = context;

            Players = new List<PlayerSprite>();
            Threats = new List<Sprite>();

            _houseSpawner = new HouseSpawner();
            _treeSpawner = new TreeSpawner();
            _angryPlaneSpawner = new AngryPlaneSpawner();
        }


        // Blockades worden in de gezamelijke lijst gestoken
        public void AddBlockade(BlockadeSprite blockade)
        {
            Threats.Add(blockade);
        }


        // Idem voor de invaders
        public void AddInvader(InvaderSprite invader)
        {
            Threats.Add(invader);
        }



        public void Update(GameTime gameTime)
        {

            if (_houseSpawner.Update(gameTime))
                AddBlockade(_context.BlockadeFactory.CreateHouse());

            if (_treeSpawner.Update(gameTime))
                AddBlockade(_context.BlockadeFactory.CreateTree());

            if (_angryPlaneSpawner.Update(gameTime))
                AddInvader(_context.InvaderFactory.CreateAngryPlane());



            foreach (PlayerSprite player in Players)
            {
                player.Update(gameTime);
            }


            foreach (Sprite threat in Threats)
            {
                threat.Update(gameTime);
            }


        }


        public void Draw(SpriteBatch spriteBatch)
        {

            foreach (PlayerSprite player in Players)
            {
                player.Draw(spriteBatch);
            }


            foreach (Sprite threat in Threats)
            {
                threat.Draw(spriteBatch);
            }


        }
    }
}
