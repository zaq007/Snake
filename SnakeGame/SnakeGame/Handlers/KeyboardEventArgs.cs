using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace SnakeGame.Handlers
{
    class KeyboardEventArgs
    {
        public List<Keys> Keys { get; set; }

        public KeyboardEventArgs(List<Keys> keys)
        {
            Keys = keys;
        }
    }
}
