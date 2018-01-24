using System;

namespace EightQueensPuzzle
{
    public class ChessBoard
    {
        public enum Piece { Blank, Queen, PossibleQueenMove }
        public Piece[,] RowsAndColumns;
        public int NumberOfRowsAndColumns;
        public int 

        public ChessBoard(int NumberOfRowsAndColumns)
        {
            this.NumberOfRowsAndColumns = NumberOfRowsAndColumns;
            ThrowExceptionIfSideSizeIsInvalid();
            CreateRowsAndColumns();
        }

        public void AddQueen()
        {
            Queen Queen = new Queen();
        }

        private void ThrowExceptionIfSideSizeIsInvalid()
        {
            ThrowExceptionIfSideSizeIsTwo();
            ThrowExceptionIfSideSizeIsThree();
        }

        private void ThrowExceptionIfSideSizeIsTwo()
        {
            if (NumberOfRowsAndColumns == 2)
            {
                throw new ArgumentException("There is no solution for a 2x2 board.");
            }
        }

        private void ThrowExceptionIfSideSizeIsThree()
        {
            if (NumberOfRowsAndColumns == 3)
            {
                throw new ArgumentException("There is no solution for a 3x3 board.");
            }

        }

        private void CreateRowsAndColumns()
        {
            RowsAndColumns = new Piece[NumberOfRowsAndColumns, NumberOfRowsAndColumns];

            for (int i = 0; i < NumberOfRowsAndColumns; i++)
            {
                for (int j = 0; j < NumberOfRowsAndColumns; j++)
                {
                    RowsAndColumns[i, j] = Piece.Blank;
                }
            }
        }


    }
}
