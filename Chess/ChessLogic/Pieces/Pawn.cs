using ChessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Pawn : PiecesBase
    {
        public override PieceTypeEnum Type => PieceTypeEnum.Pawn;
        public override Player Color { get; }
        public Pawn(Player color) 
        { 
            Color = color;
        }

        public override PiecesBase Copy()
        {
            Pawn copy = new Pawn(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
