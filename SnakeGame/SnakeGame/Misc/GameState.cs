using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeGame.Misc
{
    static class GameState
    {
        static public string State { get; set; }

        static public GameState()
        {
            State = "OK";
        }
    }
}
