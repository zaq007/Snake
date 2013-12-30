using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace SnakeGame.Handlers
{
    class KeyboardHandler : IUpdatable
    {
        KeyboardState previous;

        public event EventHandler<KeyboardEventArgs> OnPress = delegate { };

        public KeyboardHandler()
        {
            previous = Keyboard.GetState();
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState current = Keyboard.GetState();
            List<Keys> keys = current.GetPressedKeys().Where(x => previous.IsKeyUp(x)).ToList<Keys>();
            OnPress(this, new KeyboardEventArgs(keys));
        }
    }
}
