using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    internal class Circle
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }   
        private double getArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        private double getPerimeter()
        {
            return 2 * Math.PI * r;
        }
        public override string ToString()
        {
            return string.Format("r={0}\nArea={1}\nPerimeter={2}", r, getArea(), getPerimeter());
        }
    }
}
