using System;
using System.Collections.Generic;
using System.Text;

namespace FSM
{
    public class Floor
    {
        private Floor _up;
        private Floor _down;
        public Floor(int number, Floor down = null, Floor up = null, string identifier = null)
        {
            Number = number;
            _up = up;
            _down = down;
            Identity = identifier ?? number.ToString();
        }

        public Floor Up
        {
            get { return _up; }
            internal set { _up = value; }
        }

        public Floor Down
        {
            get { return _down; }
            internal set { _down = value; }
        }

        public readonly int Number;
        public readonly string Identity;

        public override string ToString()
        {
            return Identity;
        }
    }
    public class ElevatorShaft
    {
        public  Floor first;
        public int height;
        public List<Floor> floors;

        public ElevatorShaft(int height)
        {
            this.height = height;
            if (height < 1)
            {
                throw new Exception("Must contain 1 or more floors");
            }
            floors = new List<Floor>();
            Floor cache = null;
            // People generally think of floors as being 1 indexed, so lets do that for them
            for (int i = 1; i <= height; i++)
            {
                if (i == 1)
                {
                    first = new Floor(i);
                    cache = first;
                    floors.Add(first);
                }
                else
                {
                    Floor f = new Floor(i, cache);
                    cache.Up = f;
                    cache = f;
                    floors.Add(f);
                }
                
            }
        }
    }
}
