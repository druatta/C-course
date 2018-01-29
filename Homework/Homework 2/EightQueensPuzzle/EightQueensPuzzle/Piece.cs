using System;
using System.Collections;

namespace EightQueensPuzzle
{
    public class Piece 
    {
        public int[,] Index;
        public int RowNumber;
        public int ColumnNumber;

        public Piece(int RowNumber, int ColumnNumber)
        {
            this.RowNumber = RowNumber;
            this.ColumnNumber = ColumnNumber;
        }

        public Piece(ChessBoard ChessBoard)
        {

        }

    }
}
