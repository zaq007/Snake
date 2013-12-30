using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SnakeGame.Interfaces
{
    interface IDrawable
    {
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
