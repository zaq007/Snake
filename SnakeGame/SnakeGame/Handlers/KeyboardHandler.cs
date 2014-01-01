using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using SnakeGame.Interfaces;

namespace SnakeGame.Handlers
{
    static class KeyboardHandler
    {
        static KeyboardState previous;

        static public event EventHandler<KeyboardEventArgs> OnPress = delegate { };

        static KeyboardHandler()
        {
            previous = Keyboard.GetState();
        }
        
        static public void Update(GameTime gameTime)
        {
            KeyboardState current = Keyboard.GetState();
            List<Keys> keys = current.GetPressedKeys().Where(x => previous.IsKeyUp(x)).ToList<Keys>();
            OnPress(null, new KeyboardEventArgs(keys));
            previous = current;
        }
    }
}
