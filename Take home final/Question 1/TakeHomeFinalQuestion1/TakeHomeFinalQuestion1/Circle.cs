using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeFinalQuestion1
{
    class Circle : Shape
    {
        protected int radius { get; set; }
        protected new string Color { get; set; } = "Blue";

        public Circle(string name) : base(name)
        {
            Console.WriteLine("Circle called " + name + "created");
        }

        public Circle(string name, int radius) : base(name)
        {
            Console.WriteLine("Circle called " + name + "with a radius of " + radius + " created");
        }

        public override float calculateArea()
        {
            float area;
            int squared = 2;
            area = Math.PI * Math.Pow(radius, squared);
            Console.WriteLine("Area is " + area);
        }

        public override string ToString()
        {
            return "This is a circle object called " + name + 
                " whose radius is " + radius + " and area is " + area
        }
    }
}
