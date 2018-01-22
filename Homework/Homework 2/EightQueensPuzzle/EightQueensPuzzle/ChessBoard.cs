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
            RowsAndColumns = new Piece[SideSize, SideSize];
            CreateRowsAndColumns();
        }

        void CreateRowsAndColumns()
        {
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
