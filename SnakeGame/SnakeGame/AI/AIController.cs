using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SnakeGame.Objects;
using SnakeGame.Misc;
using Microsoft.Xna.Framework;
using SnakeGame.AI.A_Star;

namespace SnakeGame.AI
{
    class AIController
    {
        Snake Snake;

        public AIController(Snake s)
        {
            Snake = s;
            Snake.OnUpdate += UpdateHandler;
        }

        void UpdateHandler(object sender, EventArgs e)
        {
            var map = new int[Map.X, Map.Y];
            Eat eat = ObjectContainer.GetElementsByTag("Eat").ToArray<GameObject>()[0] as Eat;
            Point finish = new Point((int)eat.Position.X / Map.Size, (int)eat.Position.Y / Map.Size);
            foreach (var a in Snake.Nodes)
            {
                map[(int)a.Position.X / Map.Size, (int)a.Position.Y / Map.Size] = 1;
            }
            List<Point> path = PathFinder.FindPath(map, Snake.Head, finish);
            Snake.Speed = new Vector2(path[1].X - Snake.Head.X, path[1].Y - Snake.Head.Y);
        }

    }
}
