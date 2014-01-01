using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SnakeGame.Misc;
using SnakeGame.Objects;
using SnakeGame.Handlers;

namespace SnakeGame
{
    public class Game
    {
        public Game()
        {
            ObjectContainer.Add(new Snake());
        }

        public string Update(GameTime gameTime)
        {
            KeyboardHandler.Update(gameTime);
            ObjectContainer.Update(gameTime);
            return GameState.State;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            ObjectContainer.Draw(spriteBatch);
        }

    }
}
