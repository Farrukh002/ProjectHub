using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Shape
    {

        
        public virtual double calculatePerimeter()
        {
            Console.WriteLine("Calculates the Perimeter");
            return 0; 
        }
        public virtual double calculateCircumference()
        {
            Console.WriteLine("Calculates the Circumference");
            return 0;
        }
        public virtual double calculateArea()
        {
            Console.WriteLine("Calculates the area");
            return 0;
        }
        public virtual void Result()
        {
            Console.WriteLine("The Results of the shape");
        }
    }
}
