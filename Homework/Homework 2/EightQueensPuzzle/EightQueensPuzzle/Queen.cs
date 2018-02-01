using System;

namespace EightQueensPuzzle
{
    public class Queen
    {
        private static Random RandomNumberGenerator = new Random();
        private int Zero = 0;
        ChessBoard ChessBoard;

        public Queen(ChessBoard ChessBoard)
        {
            this.ChessBoard = ChessBoard;
            GenerateRowNumber();
            GenerateColumnNumber();
            AddQueenToTheChessBoardIndices();
        }

        public int RowNumber;
        private void GenerateRowNumber()
        {
            RowNumber = RandomNumberGenerator.Next(Zero, ChessBoard.SideSize);
        }

        public int ColumnNumber;
        private void GenerateColumnNumber()
        {
            ColumnNumber = RandomNumberGenerator.Next(Zero, ChessBoard.SideSize);
        }

        private void AddQueenToTheChessBoardIndices()
        {
            ChessBoard.Space[RowNumber, ColumnNumber] = ChessBoard.Piece.Queen;
        }
    }
}
