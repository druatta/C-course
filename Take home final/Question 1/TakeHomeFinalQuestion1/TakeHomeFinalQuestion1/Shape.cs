using System;

namespace TakeHomeFinalQuestion1
{
    public abstract class Shape
    {
        public string Name;
        public static int count = 0;
        protected string Color;
        
        public Shape()
        {
            count++;
            Name = "Default Shape";
            Color = "Black";
        }

        public Shape(string Name)
        {
            Console.WriteLine("Shape called " + Name + " created");
            this.Name = Name;
            count++;
        }

        public abstract double calculateArea();

        public override string ToString()
        {
            return count + " This shape object is called " + Name;
        }



    }
}
