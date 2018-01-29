using System;
using System.Collections;

namespace EightQueensPuzzle
{
    public class ChessBoard
    {
        public int SideSize;
        public Piece[,] Space;
        public enum Piece { Blank, Queen, QueenAttack }

        public ChessBoard(int SideSize)
        {
            this.SideSize = SideSize;
            ThrowExceptionIfSideSizeIsInvalid();
            InitializeBoardMatrix();
            PopulateTheBoardWithBlankSpaces();
        }

        private void ThrowExceptionIfSideSizeIsInvalid()
        {
            ThrowArgumentExceptionIfSideSizeIsTwo();
            ThrowArgumentExceptionIfSideSizeIsThree();
        }

        private void ThrowArgumentExceptionIfSideSizeIsTwo()
        {
            if (SideSize == 2)
            {
                throw new ArgumentException("There is no solution for a 2x2 board.");
            }
        }

        private void ThrowArgumentExceptionIfSideSizeIsThree()
        {
            if (SideSize == 3)
            {
                throw new ArgumentException("There is no solution for a 3x3 board.");
            }
        }


        private void InitializeBoardMatrix()
        {
            Space = new Piece[SideSize, SideSize];
        }

        private void PopulateTheBoardWithBlankSpaces()
        {
            for (int RowNumber = 0; RowNumber < SideSize; RowNumber++)
            {
                for (int ColumnNumber = 0; ColumnNumber < SideSize; ColumnNumber++)
                {
                    AddBlankSpace(RowNumber, ColumnNumber);
                }
            }
        }


        public void AddBlankSpace(int RowNumber, int ColumnNumber)
        {
            Space[RowNumber, ColumnNumber] = Piece.Blank;
        }

        public void Print()
        {
            for (int RowNumber = 0; RowNumber < SideSize; RowNumber++)
            {
                PrintTheTopOfEachSquare();
                for (int ColumnNumber = 0; ColumnNumber < SideSize; ColumnNumber++)
                {
                    PrintSquare(RowNumber, ColumnNumber);
                }
            }
        }

        private void PrintTheTopOfEachSquare()
        {
            Console.WriteLine();
            Console.Write("________________________");
            Console.WriteLine();
        }

        private void PrintSquare(int RowNumber, int ColumnNumber)
        {
            switch (Space[RowNumber,ColumnNumber]) {
                case Piece.Blank:
                    PrintABlankSpace();
                    break;
                case Piece.Queen:
                    PrintAQueen();
                    break;
                case Piece.QueenAttack:
                    PrintAQueenAttack();
                    break;
                default:
                    PrintAnErrorSpace();
                    break;
            }
        }

        private void PrintABlankSpace()
        {
            Console.Write("|B|");
        }

        private void PrintAQueen()
        {
            Console.Write("|Q|");
        }

        private void PrintAQueenAttack()
        {
            Console.Write("|A|");
        }

        private void PrintAnErrorSpace()
        {
            Console.Write("|E|");
        }


    }
}
