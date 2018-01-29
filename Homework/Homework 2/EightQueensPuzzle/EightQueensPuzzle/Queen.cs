using System;

namespace EightQueensPuzzle
{
    public class Queen : Piece
    {
        ChessBoard ChessBoard;
        public Queen(ChessBoard ChessBoard) : base(ChessBoard)
        {
            this.ChessBoard = ChessBoard;
            GenerateRowAndColumnNumber();
        }

        private static Random RandomNumberGenerator = new Random();
        private const int One = 1;

        public void GenerateRowAndColumnNumber()
        {
            GenerateRowNumber();
            GenerateColumnNumber();
        }

        public void GenerateRowNumber()
        {
            RowNumber = RandomNumberGenerator.Next(One, ChessBoard.SideSize);
        }

        public void GenerateColumnNumber()
        {
            ColumnNumber = RandomNumberGenerator.Next(One, ChessBoard.SideSize);
        }

    }
}
