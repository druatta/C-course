using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensPuzzle
{
    class QueenAttackSpace
    {
        ChessBoard ChessBoard;
        Queen Queen;

        public QueenAttackSpace(ChessBoard ChessBoard, Queen Queen)
        {
            this.ChessBoard = ChessBoard;
            this.Queen = Queen;
        }
    }
}
