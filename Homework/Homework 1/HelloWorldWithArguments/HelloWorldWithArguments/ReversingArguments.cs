using System;

namespace ReversingArguments
{
    public class ReversingArgumentsMethods
    {
        static void Main(string[] args)
        {


        }

        public static void GetASingleUserInput()
        {

        }

        static void PrintMyOriginalArguments(string[] args)
        {
            Console.WriteLine("You entered the following arguments:");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
            }
        }

        static void PrintMyReversedArguments()
        {

        }

        static void ReverseMyArguments()
        {

        }

        static void WaitForUserInput()
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
