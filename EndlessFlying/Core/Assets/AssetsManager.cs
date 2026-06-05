using EndlessFlyer.Core.Exceptions;
using EndlessFlyer.Identifiers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Core.Assets
{
    public class AssetsManager
    {
        private readonly ContentManager _contentManager;
        private readonly Dictionary<string, Texture2D> _textures;
        private readonly Dictionary<string, SpriteFont> _fonts;


        public AssetsManager(Game game)
        {
            // bestanden opvragen via de ingebouwde contentManager
            _contentManager = game.Content;
            _textures = new Dictionary<string, Texture2D>();
            _fonts = new Dictionary<string, SpriteFont>();
        }


        public Texture2D GetTexture(string name)
        {

            if (!_textures.TryGetValue(name, out var texture))
            {
                try
                {
                    // Laad de texturen op via de contentManager en voeg ze toe aan de dictionary
                    texture = _contentManager.Load<Texture2D>(name);
                    _textures.Add(name, texture);
                }

                catch (ContentLoadException ex)
                {
                    throw new AssetNotInitializedException(name, ex);
                }
            }

            return texture;
        }



        public SpriteFont GetFont(string name)
        {

            if (!_fonts.TryGetValue(name, out var font))
            {
                try
                {
                    font = _contentManager.Load<SpriteFont>(name);
                    _fonts.Add(name, font);
                }

                catch (ContentLoadException ex)
                {
                    throw new AssetNotInitializedException(name, ex);
                }
            }

            return font;
        }
    }

}

