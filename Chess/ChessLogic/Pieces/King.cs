using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class King : PiecesBase
    {
        public override PieceTypeEnum Type => PieceTypeEnum.King;

        public override Player Color { get; }
        public King(Player color) 
        { 
            Color = color;
        }

        public override PiecesBase Copy()
        {
            King copy = new King(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
