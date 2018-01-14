using ArgumentReverser;

namespace Executable
{
    class Executable
    {
        static void Main()
        {
            Constructor ArgumentReverser = new Constructor();
            ArgumentReverser.PromptTheUserForTwoCommandLineInputs();
            ArgumentReverser.GetUserInputsFromTheCommandLine();
            ArgumentReverser.PrintMyOriginalArguments();
            ArgumentReverser.PrintMyReversedArguments();
            ArgumentReverser.PauseTheConsole();
        }
    }
}
