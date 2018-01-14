using System;

namespace HelloWorldWithArguments
{
    class HelloWorldWithArguments
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!\n");
            Console.WriteLine("You entered the following arguments:");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
