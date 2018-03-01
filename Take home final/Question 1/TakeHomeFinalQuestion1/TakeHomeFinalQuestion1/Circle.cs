using System;

namespace TakeHomeFinalQuestion1
{
    class Circle : Shape
    {
        protected int radius;
        protected new string color = "Blue";

        public Circle()
        {

        }

        public Circle(string name) : base(name)
        {
            Console.WriteLine("Circle called " + name + " created");
        }

        public Circle(string name, int radius) : base(name)
        {
            Console.WriteLine("Circle called " + name + " with a radius of " + radius + " created");
            this.radius = radius;
        }

        public override double calculateArea()
        {
            double area;
            int squared = 2;
            area = Math.PI * Math.Pow(radius, squared);
            return area;
        }

        public override string ToString()
        {
            return "This is a circle object called " + name +
                " whose radius is " + radius + " and area is " + calculateArea();
        }
    }
}
