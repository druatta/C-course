using System;

namespace TakeHomeFinalQuestion1
{
    public abstract class Shape
    {
        protected string name;
        public static int count;
        protected string color = "Black";
        
        public Shape()
        {
            count++;
        }

        public Shape(string name)
        {
            Console.WriteLine("Shape called " + name + " created");
            this.name = name;
            count++;
        }

        public abstract double calculateArea();

        public override string ToString()
        {
            return count + " This shape object is called " + name;
        }



    }
}
