using System;

namespace EightQueensPuzzle
{
    public class ChessBoard
    {
        public enum Piece { Blank, Queen, PossibleQueenMove }
        public Piece[,] RowsAndColumns;
        public int SideSize;

        public ChessBoard(int SideSize)
        {
            this.SideSize = SideSize;
            ThrowExceptionIfSideSizeIsInvalid();
            CreateRowsAndColumns();
        }


        private void ThrowExceptionIfSideSizeIsInvalid()
        {
            ThrowExceptionIfSideSizeIsTwo();
            ThrowExceptionIfSideSizeIsThree();
        }

        private void ThrowExceptionIfSideSizeIsTwo()
        {
            if (SideSize == 2)
            {
                throw new ArgumentException("Board size cannot be 2x2");
            }
        }

        private void ThrowExceptionIfSideSizeIsThree()
        {

        }

        private void CreateRowsAndColumns()
        {
            RowsAndColumns = new Piece[SideSize, SideSize];

            for (int i = 0; i < SideSize; i++)
            {
                for (int j = 0; j < SideSize; j++)
                {
                    RowsAndColumns[i, j] = Piece.Blank;
                }
            }
        }


    }
}
