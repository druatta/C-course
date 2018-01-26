using System;

namespace EightQueensPuzzle
{
    public class ChessBoard
    {
        public int SideSize;
        

        public ChessBoard(int NumberOfRowsAndColumns)
        {
            this.SideSize = NumberOfRowsAndColumns;
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
                throw new ArgumentException("There is no solution for a 2x2 board.");
            }
        }

        private void ThrowExceptionIfSideSizeIsThree()
        {
            if (SideSize == 3)
            {
                throw new ArgumentException("There is no solution for a 3x3 board.");
            }

        }

        private void CreateRowsAndColumns()
        {
            
        }


    }
}
