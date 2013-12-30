using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeGame.Misc
{
    class Map
    {
        enum MapState
        {
            None = 0,
            Snake,
            Eat            
        }
        public MapState[, ] Map { get; set; }
        public double Size { get; set; }

        public Map(int x, int y, double a)
        {
            Map = new MapState[x, y];
            Size = a;
        }


    }
}
