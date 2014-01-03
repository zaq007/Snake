using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SnakeGame.AI.A_Star
{
    public class PathNode
    {

        public Point Position { get; set; }

        public int PathLengthFromStart { get; set; }

        public PathNode CameFrom { get; set; }

        public int HeuristicEstimatePathLength { get; set; }

        public int EstimateFullPathLength
        {
            get
            {
                return this.PathLengthFromStart + this.HeuristicEstimatePathLength;
            }
        }
    }
}
