using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SnakeGame.Objects
{
    class Eat : GameObject
    {
        public Eat(Texture2D texture, Vector2 pos)
            : base(texture, pos)
        {
            Tag = "Eat";
        }

        public override void Update(GameTime gameTime)
        {

        }

    }
}
