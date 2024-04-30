using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Moves
{
    public abstract class MoveBase
    {
        public abstract MoveType MoveType { get; }
        public abstract Position FromPos { get; }
        public abstract Position ToPos { get; }

        public abstract void Execute(Board board);
    }
}
