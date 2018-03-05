using System;

namespace TakeHomeFinalQuestion1
{
    class Rectangle : Shape
    {
        public int Width;
        public int Length;
        protected const int defaultWidth = 5;
        protected const int defaultLength = 10;
        public new string Color = "Red";

        public Rectangle()
        {
            Console.WriteLine("Default Rectangle created");
            Name = "Default Rectangle";
        }

        public Rectangle(string name) : base(name)
        {
            Console.WriteLine("Rectangle called " + name + " created " +
                "with default length and width");
            Width = defaultWidth;
            Length = defaultLength;
        }

        public Rectangle(string name, int length, int width) : base(name)
        {
            Console.WriteLine("Rectangle called " + name +  
                " created with length " + length + " and width " + width);
            this.Length = length;
            this.Width = width;
        }

        public override double calculateArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return "This is a Rectangle object called " + Name + " whose length is "
                + Length + " and width is " + Width + " and area is " + calculateArea() +
                " of color " + Color;
        }



    }
}
