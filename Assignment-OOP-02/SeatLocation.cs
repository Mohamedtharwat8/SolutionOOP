using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_02
{
    public struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }
        public override string ToString() => $"{Row}-{Number}";
    }

}
