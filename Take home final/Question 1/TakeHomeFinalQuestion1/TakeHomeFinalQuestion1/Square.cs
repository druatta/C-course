using System;

namespace TakeHomeFinalQuestion1
{
    class Square : Rectangle
    {
        public new string Color = "White";

        public Square()
        {
            Console.WriteLine("Default Square created");
            Name = "Default Square";
        }

        public Square(string Name) : base(Name)
        {
            Console.WriteLine("Square called " + Name +
                " created with default length and width");
            this.Name = Name;
            Width = Length;
        }

        public Square(string name, int Width)
        {
            Console.WriteLine("Square called " + name +
                " created with length and width equal to " + Width);
            Length = Width;
            this.Width = Width;
        }

        public override string ToString()
        {
            return "This is a Square object called " + Name +
                " whose length is " + Length + " and width is " +
                Width + " and area is " + calculateArea() + " of color "
                + Color;
        }
        
    }
}
