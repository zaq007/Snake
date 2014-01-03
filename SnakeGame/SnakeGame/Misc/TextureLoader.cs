using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SnakeGame.Misc
{
    public static class TextureLoader
    {
        private static ContentManager content;

        public static void Initialize(ContentManager contentManager)
        {
            content = contentManager;
        }

        static Texture2D snakeNode;
        public static Texture2D SnakeNode
        {
            get
            {
                if (snakeNode == null)
                    snakeNode = content.Load<Texture2D>("SnakeNode");
                return snakeNode;
            }
        }

        static Texture2D eat;
        public static Texture2D Eat
        {
            get
            {
                if (eat == null)
                    eat = content.Load<Texture2D>("SnakeNode");
                return eat;
            }
        }

    }
}
