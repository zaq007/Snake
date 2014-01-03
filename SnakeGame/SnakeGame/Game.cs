using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SnakeGame.Misc;
using SnakeGame.Objects;
using SnakeGame.Handlers;
using SnakeGame.AI;

namespace SnakeGame
{
    public class Game
    {
        EatController eatController;
        AIController aiController;

        public Game()
        {
            ObjectContainer.Add(new Snake());
            eatController = new EatController();
            aiController = new AIController((Snake)ObjectContainer.GetElementsByTag("Snake").ToArray<GameObject>()[0]);
        }

        public string Update(GameTime gameTime)
        {
            eatController.Update(gameTime);
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
