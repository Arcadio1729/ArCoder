using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class MapDirectionMethods
    {   
        public static Vector2d toUnitVector(this MapDirection md)
        {
            switch (md)
            {
                case MapDirection.NORTH:
                    return new Vector2d(0, 1);
                case MapDirection.SOUTH:
                    return new Vector2d(0, -1);
                case MapDirection.EAST:
                    return new Vector2d(1, 0);
                case MapDirection.WEST:
                    return new Vector2d(-1, 0);
                default:
                    return null;                    
            }
        }

        public static MapDirection next(this MapDirection md)
        {
            switch (md)
            {
                case MapDirection.SOUTH:
                    return MapDirection.WEST;
                case MapDirection.WEST:
                    return MapDirection.NORTH;
                case MapDirection.NORTH:
                    return MapDirection.EAST;
                case MapDirection.EAST:
                    return MapDirection.SOUTH;
                default:
                    return MapDirection.EAST;
            }
        }


        public static MapDirection previous(this MapDirection md)
        {
            switch (md)
            {
                case MapDirection.SOUTH:
                    return MapDirection.EAST;
                case MapDirection.WEST:
                    return MapDirection.SOUTH;
                case MapDirection.NORTH:
                    return MapDirection.WEST;
                case MapDirection.EAST:
                    return MapDirection.NORTH;
                default:
                    return MapDirection.WEST;
            }
        }
    }


}
