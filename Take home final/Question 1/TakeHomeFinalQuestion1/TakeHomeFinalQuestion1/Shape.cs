using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeFinalQuestion1
{
    public abstract class Shape
    {
        protected string name { get; set; }
        static int count { get; set;}
        protected string Color = "Black";

        Shape(string name)
        {
            Console.WriteLine("Shape called" + name + " created");
            count++;
        }

        public abstract void calculateArea();

        void ToString()
        {
            Console.WriteLine("");
        }



    }
}
