using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Circle : Shape
    {
        private double r;
        private double circumference;
        private double area;

        public Circle(double r)
        { 
            this.r = r;
        }

        public override double calculateCircumference()
        {
            circumference = 2 * Math.PI * r;
            return circumference;
            
        }
        public override double calculateArea()
        {
            area = Math.PI * Math.Pow(r,2);
            return area;
        }

        public override void Result()
        {
            Console.WriteLine("radius={0}\nArea={1}\nCircumference={2}\n", r, calculateArea(), calculateCircumference());
        }


    }
}
