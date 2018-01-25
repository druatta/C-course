using System;

namespace EightQueensPuzzle
{
    class Piece
    {
        private Random RandomNumberGenerator = new Random();
        private const int One = 1;

        public struct RowAndColumnIndex
        {
            private int CurrentRowNumber;
            private int CurrentColumnNumber;

            public RowAndColumnIndex(int RowNumber, int ColumnNumber)
            {
                CurrentRowNumber = RowNumber;
                CurrentColumnNumber = ColumnNumber; 
            }

            public int RowNumber
            {
                get
                {
                    return CurrentRowNumber;
                }
                set
                {
                    CurrentRowNumber = value;
                }
            }

            public int ColumnNumber
            {
                get
                {
                    return CurrentColumnNumber;
                }
                set
                {
                    CurrentColumnNumber = value;
                }
            }
        }

        public Piece(ChessBoard ChessBoard)
        {
            CreateRowAndColumnIndex();
        }

        private void CreateRowAndColumnIndex()
        {
            CreateRowNumber();
            CreateColumnNumber();
        }

        private void CreateRowNumber(ChessBoard ChessBoard)
        {
            RowAndColumnIndex.RowNumber = RandomNumberGenerator.Next(One, ChessBoard.NumberOfRowsAndColumns)
        }

        private void CreateColumnNumber()
        {

        }
    }
}
