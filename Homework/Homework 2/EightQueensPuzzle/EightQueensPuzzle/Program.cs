using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensPuzzle
{
    public class Program
    {
        bool Solved = false;
        int NumberOfQueens = 0;
        public ChessBoard ChessBoard;
        public Program()
        {
            int SideSize = 8;
            ChessBoard ChessBoard = new ChessBoard(SideSize);
        }

        static void Main(string[] args)
        {
            Program Program = new Program();

            while (Program.Solved == false)
            {
                Program.WaitFiveSeconds();
                Program.ChessBoard.Print();
                Program.RandomlyPlaceAQueen();
            }

            Program.PromptTheUserForInput();
            Program.WaitForUserInputBeforeClosingTheProgram();
        }


        public void PromptTheUserForInput()
        {
            Console.WriteLine("Press a key to exit the program");
        }

        public void WaitForUserInputBeforeClosingTheProgram()
        {
            Console.ReadKey();
        }

        public void ExitTheProgramIfTheNumberOfQueensOnTheBoardIsEight()
        {
            if (NumberOfQueens == 8)
            {
                Solved = true;
            }
        }

        public void WaitFiveSeconds()
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public void RandomlyPlaceAQueen()
        {
            Queen Queen = new Queen(ChessBoard);
        }


    }
}
