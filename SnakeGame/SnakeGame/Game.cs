using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SnakeGame.Misc;

namespace SnakeGame
{
    public class Game
    {
        public Game()
        {
           
        }

        public string Update(GameTime gameTime)
        {
            return GameState.State;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
