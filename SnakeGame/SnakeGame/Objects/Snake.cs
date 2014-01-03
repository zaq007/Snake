using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SnakeGame.Misc;
using SnakeGame.Handlers;

namespace SnakeGame.Objects
{
    class Snake : GameObject
    {
        public event EventHandler OnUpdate = delegate { };
        public event EventHandler OnEat = delegate { };

        public Point Head { get; set; }
        TimeSpan Time;
        public List<SnakeNode> Nodes { get; set; }

        public Snake() : base()
        {
            Head = new Point(2, 0);
            Speed = new Vector2(1, 0);
            Time = new TimeSpan(0, 0, 1);
            Nodes = new List<SnakeNode>();
            Nodes.Add(new SnakeNode(TextureLoader.SnakeNode, new Vector2(2*Map.Size, 0)));
            Nodes.Add(new SnakeNode(TextureLoader.SnakeNode, new Vector2(1*Map.Size, 0)));
            Nodes.Add(new SnakeNode(TextureLoader.SnakeNode, new Vector2(0, 0)));
            Tag = "Snake";
            KeyboardHandler.OnPress += KeyHandler;
        }

        void KeyHandler(object sender, KeyboardEventArgs e)
        {
            if (e.Keys.Contains(Microsoft.Xna.Framework.Input.Keys.Down) && Speed.Y!=-1)
                Speed = new Vector2(0, 1);
            if (e.Keys.Contains(Microsoft.Xna.Framework.Input.Keys.Up) && Speed.Y!=1)
                Speed = new Vector2(0, -1);
            if (e.Keys.Contains(Microsoft.Xna.Framework.Input.Keys.Right) && Speed.X!=-1)
                Speed = new Vector2(1, 0);
            if (e.Keys.Contains(Microsoft.Xna.Framework.Input.Keys.Left) && Speed.X!=1)
                Speed = new Vector2(-1, 0);
        }

        public override void Update(GameTime gameTime)
        {
            Time -= gameTime.ElapsedGameTime;
            if (Time <= TimeSpan.Zero)
            {
                int x = Head.X;
                int y = Head.Y;
                int nextX = (int)(x + Speed.X);
                int nextY = (int)(y + Speed.Y);
                Head = new Point(nextX, nextY);
                if (nextX >= Map.X || nextX < 0 || nextY >= Map.Y || nextY < 0)
                {
                    GameState.State = "DEAD";
                    return;
                }
                GameObject eat = ObjectContainer.GetElementsByTag("Eat").ToList<GameObject>()[0];
                Vector2 eatPosition = eat.Position;
                if (new Rectangle((int)eatPosition.X, (int)eatPosition.Y, Map.Size, Map.Size).Intersects(new Rectangle(nextX * Map.Size, nextY * Map.Size, Map.Size, Map.Size)))
                {
                    Nodes.Insert(0, new SnakeNode(TextureLoader.SnakeNode, eatPosition));
                    ObjectContainer.Remove(eat);
                    OnEat(this, null);
                    OnUpdate(this, null);
                    return;
                }
                    
                for (int i = 0; i < Nodes.Count; i++)
                {
                    x = (int)Nodes[i].Position.X/Map.Size;
                    y = (int)Nodes[i].Position.Y/Map.Size;
                    Nodes[i].Position = new Vector2(nextX * Map.Size, nextY * Map.Size);
                    nextX = x;
                    nextY = y;
                }
                Time = new TimeSpan(0, 0, 1);
                OnUpdate(this, null);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var a in Nodes)
                a.Draw(spriteBatch);
        }
    }
}
