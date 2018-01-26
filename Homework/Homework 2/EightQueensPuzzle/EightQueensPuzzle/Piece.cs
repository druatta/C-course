using System;

namespace EightQueensPuzzle
{
    public class Piece
    {
        private static Random RandomNumberGenerator = new Random();
        private const int One = 1;
        public int RowNumber; 
        public int ColumnNumber;

        public Piece(ChessBoard ChessBoard)
        {
            GenerateRowNumber(ChessBoard);
            GenerateColumnNumber(ChessBoard);
        }

        public void GenerateRowNumber(ChessBoard ChessBoard)
        {
            RowNumber = RandomNumberGenerator.Next(One, ChessBoard.SideSize);
        }

        public void GenerateColumnNumber(ChessBoard ChessBoard)
        {
            ColumnNumber = RandomNumberGenerator.Next(One, ChessBoard.SideSize);
        }
        
    }
}
