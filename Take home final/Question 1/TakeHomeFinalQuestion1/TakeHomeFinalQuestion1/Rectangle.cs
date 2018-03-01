using System;

namespace TakeHomeFinalQuestion1
{
    class Rectangle : Shape
    {
        protected int width;
        protected int length;
        protected const int defaultWidth = 5;
        protected const int defaultLength = 10;
        protected new string color = "Red";

        public Rectangle()
        {

        }

        public Rectangle(string name) : base(name)
        {
            Console.WriteLine("Rectangle called " + name + " created");
            width = defaultWidth;
            length = defaultLength;
        }

        public Rectangle(string name, int length, int width) : base(name)
        {
            Console.WriteLine("Rectangle called " + name +  
                " created with length " + length + " and width " + width);
            this.length = length;
            this.width = width;
        }

        public override double calculateArea()
        {
            return length * width;
        }

        public override string ToString()
        {
            return "This is a Rectangle object called " + name + " whose length is "
                + length + " and width is " + width + " and area is " + calculateArea() +
                " of color " + color;
        }



    }
}
