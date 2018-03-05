using System;

namespace TakeHomeFinalQuestion1
{
    class Circle : Shape
    {
        public int Radius;
        public new string Color = "Blue";

        public Circle()
        {
            Console.WriteLine("Default Circle created");
            Name = "Default Circle";
        }

        public Circle(string Name) : base(Name)
        {
            Console.WriteLine("Circle called " + Name + " created");
            this.Name = Name;
        }

        public Circle(string Name, int Radius)
        {
            Console.WriteLine("Circle called " + Name + " with a radius of " + Radius + " created");
            this.Radius = Radius;
            this.Name = Name;
        }

        public override double calculateArea()
        {
            double area;
            int squared = 2;
            area = Math.PI * Math.Pow(Radius, squared);
            return area;
        }

        public override string ToString()
        {
            return "This is a circle object called " + Name +
                " whose radius is " + Radius + " and area is " + calculateArea() + " of color " + Color;
        }
    }
}
