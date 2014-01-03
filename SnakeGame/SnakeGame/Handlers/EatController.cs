using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using SnakeGame.Objects;
using SnakeGame.Misc;

namespace SnakeGame.Handlers
{
    class EatController
    {
        public EatController()
        {
            Snake snake = ObjectContainer.GetElementsByTag("Snake").ToArray<GameObject>()[0] as Snake;
            snake.OnEat += OnEat;
        }

        public void Update(GameTime gameTime)
        {
            if (ObjectContainer.GetElementsByTag("Eat").ToList<GameObject>().Count == 0)
            {
                Random r = new Random();
                ObjectContainer.Add(new Eat(TextureLoader.Eat, new Vector2(Map.Size*r.Next(19), Map.Size*r.Next(19))));
            }
        }

        void OnEat(object sender, EventArgs e)
        {
            Random r = new Random();
            ObjectContainer.Add(new Eat(TextureLoader.Eat, new Vector2(Map.Size * r.Next(19), Map.Size * r.Next(19))));
        }

    }
}
