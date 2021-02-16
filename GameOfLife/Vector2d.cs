using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Vector2d
    {
        public readonly int x;
        public readonly int y;

        public Vector2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string toString()
        {
            return $"({this.x},{this.y})";
        }

        public bool preceeds(Vector2d other)
        {
            if (this.x <= other.x && this.y <= other.y) return true;
            return false;
        }

        public bool follows(Vector2d other)
        {
            if (this.x >= other.x && this.y >= other.y) return true;
            return false;
        }

        public Vector2d upperRight(Vector2d other)
        {
            int maxX = Math.Max(this.x, other.x);
            int maxY = Math.Max(this.y, other.y);

            return new Vector2d(maxX, maxY);
        }

        public Vector2d lowerLeft(Vector2d other)
        {
            int minX = Math.Min(this.x, other.x);
            int minY = Math.Min(this.y, other.y);

            return new Vector2d(minX, minY);
        }

        public Vector2d add(Vector2d other)
        {
            return new Vector2d(this.x + other.x, this.y + other.y);
        }

        public Vector2d subtract(Vector2d other)
        {
            return new Vector2d(this.x - other.x, this.y - other.y);
        }

        public Boolean equals(Object other)
        {
            if (this == other) return true;
            if (!(other.GetType().ToString() == "Vector2d")) return false;

            Vector2d that = (Vector2d)other;

            if (this.x == that.x && this.y == that.y) return true;
            return false;
        }

        public Vector2d opposite()
        {
            return new Vector2d(-this.x, -this.y);
        }
    }
}
