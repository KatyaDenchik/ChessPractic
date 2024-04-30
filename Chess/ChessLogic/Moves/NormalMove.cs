using ChessLogic.Enums;
using ChessLogic.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Moves
{
    public class NormalMove : MoveBase
    {
        public override MoveType MoveType => MoveType.Normal;

        public override Position FromPos { get; }

        public override Position ToPos { get; }

        public NormalMove(Position from, Position to)
        {
            FromPos = from;
            ToPos = to;
        }

        public override void Execute(Board board)
        {
            PieceBase piece = board[FromPos];
            board[ToPos] = piece;
            board[FromPos] = null;
            piece.HasMoved = true;
        }
    }
}
