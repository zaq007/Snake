using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using SnakeGame.Interfaces;
using Microsoft.Xna.Framework;

namespace SnakeGame.Objects
{
    class GameObject : Interfaces.IDrawable, IUpdatable
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public Vector2 Velocity { get; set; }
        public bool Visibility { get; set; }
        public string Tag { get; set; }

        public GameObject() { }

        public GameObject(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
        }

        public virtual void Update(GameTime gameTime)
        {        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

    }
}
