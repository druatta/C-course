using System;

namespace ArgumentReverser
{
    public class Constructor
    {
        string[] UserInput;
        
        public void PromptTheUserForTwoCommandLineInputs()
        {
            Console.WriteLine("Enter two command line inputs separated by a space, then press enter" +
                 "\n(e.g. Argument1 Argument2)");
        }

        public void GetUserInputsFromTheCommandLine()
        {
            UserInput = Console.ReadLine().Split(' ');
        }

        public void PrintMyOriginalArguments()
        {
            Console.WriteLine("\nYou entered the following arguments:");

            for (int i = 0; i < UserInput.Length; i++)
            {
                Console.WriteLine("{0}", UserInput[i]);
            }
        }

        public void PrintMyReversedArguments()
        {
            Console.WriteLine("\nHere are your arguments in reverse:");

            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}", UserInput[i]);
            }
        }
        public void PauseTheConsole()
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

    }
}
