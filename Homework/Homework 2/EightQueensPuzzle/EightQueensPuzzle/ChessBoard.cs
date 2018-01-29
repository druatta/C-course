using System;
using System.Collections;

namespace EightQueensPuzzle
{
    public class ChessBoard
    {
        public int SideSize;
        public int[,] Space;
        public enum Piece {Blank, Queen, QueenMove}

        public ChessBoard(int SideSize)
        {
            this.SideSize = SideSize;
            ThrowExceptionIfSideSizeIsInvalid();
            InitializeBoardIndicesWithZeroes();
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

        private void InitializeBoardIndicesWithZeroes()
        {
            Space = new int[SideSize, SideSize];
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

        public void TryToAddAQueen()
        {

        }

        public void AddBlankSpace(int RowNumber, int ColumnNumber)
        {
            Space[RowNumber, ColumnNumber] = Piece.Blank;
        }

        public void AddQueenMove(int RowNumber, int ColumnNumber)
        {

        }



    }
}
