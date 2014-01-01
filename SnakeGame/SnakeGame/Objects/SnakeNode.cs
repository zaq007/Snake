using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SnakeGame.Objects
{
    class SnakeNode : Interfaces.IDrawable, Interfaces.IUpdatable
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }


        public SnakeNode(Texture2D texture, Vector2 pos)
        {
            Texture = texture;
            Position = pos;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

    }
}
