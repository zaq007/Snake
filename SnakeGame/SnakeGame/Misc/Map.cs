using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeGame.Misc
{
    static class Map
    {
        static public int X { get; set; }
        static public int Y { get; set; }
        static public int Size { get;set; }

        static Map()
        {
            X = 20;
            Y = 20;
            Size = 16;
        }
    }
}
