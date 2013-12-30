using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SnakeGame.Objects
{
    class GameObject
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Vector2 Speed;   
        public Vector2 Velocity;
        public bool Visibility; 
                                

        public GameObject(Texture2D texture, Vector2 position)
        {

        }

        public virtual void Update(GameTime gameTime)
        {        }

        public virtual void Draw(GameTime gameTime)
        {        }

    }
}
