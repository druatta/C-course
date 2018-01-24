

namespace EightQueensPuzzle
{
    class Queen
    {
        public Queen(ChessBoard ChessBoard)
        {
            FindAnOpenSpaceOnTheBoard(ChessBoard);
            FindASpaceOutsideOfAQueensReach(ChessBoard);
        }



        private void FindAnOpenSpaceOnTheBoard(ChessBoard ChessBoard)
        {
            foreach (ChessBoard.Piece Element in ChessBoard.RowsAndColumns)
            {

            }
        }

        private void FindASpaceOutsideOfAQueensReach(ChessBoard ChessBoard)
        {
            foreach (ChessBoard.Piece Element in ChessBoard.RowsAndColumns)
            {
                if (Element != Piece.PossibleQueenMove)
                {

                }
            }
        }
    }
}
