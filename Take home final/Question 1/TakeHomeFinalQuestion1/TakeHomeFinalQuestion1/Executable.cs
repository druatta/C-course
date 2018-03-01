using System;

namespace TakeHomeFinalQuestion1
{
    class Executable
    {
        public static void Main()
        {
            Circle circleA = new Circle();
            Circle circleB = new Circle("Circle-B");
            Circle circleC = new Circle("Circle-C", 5);
            Rectangle rectangleA = new Rectangle();
            Rectangle rectangleB = new Rectangle("Rectangle-B");
            Rectangle rectangleC = new Rectangle("Rectangle-C", 5, 8);
            Square squareA = new Square();

            Console.WriteLine("Count is " + Shape.count);
            Console.Read();
        }
    }
}
