using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Animal
    {
        private Vector2d position;
        private MapDirection orientation;

        public Animal()
        {
            this.orientation = MapDirection.NORTH;
            this.position = new Vector2d(2, 2);

        }


        public void move(MoveDirection md)
        {
            switch (md)
            {
                case MoveDirection.RIGHT:
                    this.orientation = this.orientation.next();
                    break;
                case MoveDirection.LEFT:
                    this.orientation = this.orientation.previous();
                    break;

            }
        }
        public string toString()
        {
            return this.orientation.ToString() + " " + this.position.toString();
        }
    }
}
