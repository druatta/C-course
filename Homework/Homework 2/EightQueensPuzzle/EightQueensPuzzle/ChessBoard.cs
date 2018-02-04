using System;

namespace EightQueensPuzzle
{
    public class ChessBoard
    {
        public int SideSize;
        public Piece[,] Space;
        private enum RowNumber { Zero, One, Two, Three, Four, Five, Six, Seven}
        private enum ColumnNumber { Zero, One, Two, Three, Four, Five, Six, Seven}

        public enum Piece { Blank, Queen }

        public ChessBoard(int SideSize)
        {
            this.SideSize = SideSize;
            ThrowExceptionIfSideSizeIsInvalid();
            InitializeBoardMatrix();
            AddQueens();
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

        public void AddQueens()
        {
            AddQueen(RowNumber.Zero, ColumnNumber.Three);
            AddQueen(RowNumber.One, ColumnNumber.Six);
            AddQueen(RowNumber.Two, ColumnNumber.Two);
            AddQueen(RowNumber.Three, ColumnNumber.Seven);
            AddQueen(RowNumber.Four, ColumnNumber.Two);
            AddQueen(RowNumber.Five, ColumnNumber.Four);
            AddQueen(RowNumber.Six, ColumnNumber.Zero);
            AddQueen(RowNumber.Seven, ColumnNumber.Five);
        }

        private void AddQueen(RowNumber RowNumber, ColumnNumber ColumnNumber)
        {
            Space[(int)RowNumber, (int)ColumnNumber] = Piece.Queen;
        }

        private void PrintTheEndOfTheRow()
        {
            Console.Write("|");
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
                PrintTheEndOfTheRow();
            }
        }

        private void PrintTheTopOfEachSquare()
        {
            Console.WriteLine();
            Console.Write("_________________");
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
            }
        }

        private void PrintABlankSpace()
        {
            Console.Write("| ");
        }

        private void PrintAQueen()
        {
            Console.Write("|Q");
        }
    }
}
