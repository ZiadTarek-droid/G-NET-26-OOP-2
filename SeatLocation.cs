using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct SeatLocation
    {
        public char Row;
        public int Number;

        public override string ToString()
        {
            return $"{Row}-{Number}";
        }
    }
}