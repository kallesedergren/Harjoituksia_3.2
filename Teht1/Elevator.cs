using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Elevator
    {
        private readonly int FloorValue = 1;
        private int floorvalue;

        public int Floor
        {
            get
            {
                return floorvalue;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("There's no such floor, go up. ");
                    floorvalue = FloorValue;
                }
                else if (value > 5)
                {
                    Console.WriteLine("There's no such floor, go down. ");
                    floorvalue = FloorValue;
                }
                else
                {
                    floorvalue = value;
                }
            }

        }
    }
}
