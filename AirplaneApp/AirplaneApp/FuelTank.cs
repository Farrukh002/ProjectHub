using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneApp
{
    internal class FuelTank
    {
        public FuelTank(int capacity, double level)
        {
            Capacity = capacity;
            Level = level;
        }

        public int Capacity { get; set; }
        public double Level { get; set; }
    }
}
