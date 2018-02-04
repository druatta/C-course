using System;

namespace EightQueensPuzzle
{
    public class Program
    {
        public ChessBoard ChessBoard;
        public Program()
        {
            int SideSize = 8;
            ChessBoard = new ChessBoard(SideSize);
        }

        static void Main(string[] args)
        {
            Program Program = new Program();

            Program.ChessBoard.Print();

            Program.PromptTheUserForInput();
            Program.WaitForUserInputBeforeClosingTheProgram();
        }


        public void PromptTheUserForInput()
        {
            Console.WriteLine("\n\nPress a key to exit the program");
        }

        public void WaitForUserInputBeforeClosingTheProgram()
        {
            Console.ReadKey();
        }



    }
}
