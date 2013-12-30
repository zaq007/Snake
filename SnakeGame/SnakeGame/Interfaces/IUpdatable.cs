using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SnakeGame.Handlers
{
    interface IUpdatable
    {
        public abstract void Update(GameTime gameTime);
    }
}
